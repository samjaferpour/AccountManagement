using AccountManagement.Contract.Dto;
using AccountManagement.Contract.Interfaces.Repositories;
using AccountManagement.Contract.Interfaces.Services;
using AccountManagement.Domain.Entities;
using AccountManagement.Domain.Enums;
using AccountManagement.Framework.RabitMQ;
using Common.Exceptions;
using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Text;

namespace AccountManagement.Service.Services
{
    public class LetterService : ILetterService
    {
        private readonly ILetterRepository _letterRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IQueueProducer _queueProducer;

        public LetterService(ILetterRepository letterRepository,
                             IUnitOfWork unitOfWork,
                             IQueueProducer queueProducer)
        {
            _letterRepository = letterRepository;
            _unitOfWork = unitOfWork;
            _queueProducer = queueProducer;
        }

        public async Task AddLetterAsync(Letter letter)
        {
            await _letterRepository.InsertAsync(letter);

        }
        public async Task<FindLetterByIdResponse> FindLetterById(FindLetterByIdRequest request)
        {
            var letter = await _letterRepository.FindById(request.LetterId);
            var result = new FindLetterByIdResponse
            {
                Content = letter.Content,
                Date = letter.Date,
                Deadline = letter.Deadline,
                Number = letter.Number,
                Title = letter.Title,
                ReceiptDate = letter.ReceiptDate,
                ContextImage = letter.ContextImage
            };
            return result;
        }
        public async Task<GetLetterTypeResponse> GetLetterTypes()
        {
            var letterTypes = await _letterRepository.GetLetterTypes();
            List<LetterTypeItem> LetterTypeItems = new List<LetterTypeItem>();
            GetLetterTypeResponse response = new GetLetterTypeResponse();

            foreach (var item in letterTypes)
            {
                LetterTypeItems.Add(new LetterTypeItem { Code = item.Id, Title = item.Title });
            }
            response.LetterTypeItems = LetterTypeItems;

            return response;
        }

        public async Task<GenerateTrackingCodeResponse> GenerateTracking(GenerateTrackingCodeRequest request)
        {
            var response = new GenerateTrackingCodeResponse();
            var trackingCode = Guid.NewGuid();
            var letter = new Letter
            {
                Date = request.LetterDate,
                Number = request.LetterNumber,
                Title = request.LetterTitle,
                Content = request.LetterContent,
                Deadline = request.Deadline,
                ReceiptDate = request.ReceiptDate,
                TrackingCode = trackingCode,
                LetterTypeId = (int)request.LetterType,
                ContextImage = request.ContextImage,
                DemandCount=request.DemandItems.Count
            };
            await _letterRepository.InsertAsync(letter);
            await _unitOfWork.SaveChangesAsync();
            SendToQueue(letter.Id, request);
            response.TrackingCode = trackingCode;
            return response;
        }


        public async Task<Guid> GetLetterIdByTrackingCode(Guid trackingCode)
        {
            await ValidateTrackingCode(trackingCode);
            return await _letterRepository.FindIdByTrackingCode(trackingCode);
        }
        public async Task<GetLetterProgressResponse> GetLetterProgress(GetLetterProgressRequest request)
        {
            await ValidateTrackingCode(request.TrackingCode);
            await ValidateLetterTransaction(request.TrackingCode);
            var progressResponse = await _letterRepository.LetterProgress(request.TrackingCode);
            return new GetLetterProgressResponse
            {
                DoneCount = progressResponse.DoneCount,
                Total = progressResponse.TotalCount,
                Percent = (int)Math.Round((double)(100 * progressResponse.DoneCount) / progressResponse.TotalCount)
            };
        }
        public async Task<GetBlockTransactionsResponse> GetBlockTransactions(GetBlockTransactionsRequest request)
        {
            var blockTransaction = await _letterRepository.GetBlockTransactions(request);
            return blockTransaction;
        }

        private async Task ValidateTrackingCode(Guid trackingCode)
        {
            var isExist = await _letterRepository.IsExistTrackingCode(trackingCode);
            if (isExist == false)
            {
                throw new NotFoundException("کد رهگیری نامعتبر است");
            }
        }
        private async Task ValidateLetterTransaction(Guid trackingCode)
        {
            var isExist = await _letterRepository.HasAnyDemand(trackingCode);
            if (isExist == false)
            {
                throw new LogicException("سرویس در حال آماده سازی می باشد. لطفا مجدد تلاش کنید. ");
            }
        }
        private void SendToQueue(Guid letterId, GenerateTrackingCodeRequest request)
        {
            var demandItems=new List<ExecutDemandPacketRequest>();
            foreach (var demandItem in request.DemandItems)

            {
                var demandPacket = new ExecutDemandPacketRequest
                {
                    BlockUnblockReason = demandItem.BlockUnblockReasonId,
                    AccountOwnershipTypes = demandItem.AccountOwnershipTypeIds,
                    TraceCode = demandItem.TraceCode,
                    LetterId = letterId,
                    Value = demandItem.Value,
                    BlockUnblockPassword = demandItem.BlockUnblockPassword,
                    SwiftType = demandItem.SwiftTypeId,
                    SubscriptionTypes = demandItem.SubscriptionTypeIds,
                    LetterType=request.LetterType,
                };
                demandItems.Add(demandPacket);
            };
            _queueProducer.SendMessages("ExecutDemandPacket", demandItems);
        }
    }
}



