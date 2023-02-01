using AccountManagement.Contract.Dto;
using AccountManagement.Contract.Enums;
using AccountManagement.Contract.Interfaces.Repositories;
using AccountManagement.Contract.Interfaces.Services;
using AccountManagement.Domain.Entities;
using AccountManagement.Domain.Enums;
using AccountManagement.Framework.RabitMQ;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Service.Services
{
    public class DemandPacketService : IDemandPacketService
    {
        private readonly IDemandPacketRepository _demandPacketRepository;
        private readonly ICustomerService _customerService;
        private readonly IAccountService _accountService;
        private readonly ILetterService _letterService;
        private readonly IBlockAccountTransactionService _blockAccountTransactionService;
        private readonly IWithdrawAccountTransactionService _withdrawAccountTransactionService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IQueueProducer _queueProducer;

        public DemandPacketService(IDemandPacketRepository demandPacketRepository,
                                   ICustomerService customerService,
                                   IAccountService accountService,
                                   ILetterService letterService,
                                   IBlockAccountTransactionService blockAccountTransactionService,
                                   IWithdrawAccountTransactionService withdrawAccountTransactionService,
                                   IUnitOfWork unitOfWork,
                                   IQueueProducer queueProducer)
        {
            _demandPacketRepository = demandPacketRepository;
            _customerService = customerService;
            _accountService = accountService;
            _letterService = letterService;
            _blockAccountTransactionService = blockAccountTransactionService;
            _withdrawAccountTransactionService = withdrawAccountTransactionService;
            _unitOfWork = unitOfWork;
            _queueProducer = queueProducer;
        }
        #region Public Methods
        public async Task<ExecutDemandPacketStatus> ExecutDemandPacket(ExecutDemandPacketRequest request)
        {
            AddDemandPacketRequest addDemandPacketRequest = GenerateAddDemandRequest(request);
            var demandPacketId = await Add(addDemandPacketRequest);
            await SaveChanges();
            switch (request.LetterType)
            {
                case LetterTypeEnum.NationalCode:
                   return await DemandByNationalCode(request, demandPacketId);
            }
            return ExecutDemandPacketStatus.Unsuccessful;

        }

        public async Task<Guid> Add(AddDemandPacketRequest request)
        {
            var demandPacketAccountOwnershipTypes = new List<DemandPacketAccountOwnershipType>();
            var demandPacketSubscriptionTypes = new List<DemandPacketSubscriptionType>();
            var demandPacket = new DemandPacket
            {
                LetterId = request.LetterId,
                BlockUnblockReasonId = (int)request.BlockUnblockReason,
                SwiftTypeId = (int)request.SwiftType,
                DemandStatusId = (int)request.DemandStatus,
                TraceCode = request.TraceCode,
                Value = request.Value,
                BlockUnblockPassword = request.BlockUnblockPassword,
            };
            foreach (var accountOwnershipType in request.AccountOwnershipTypes)
            {
                var demandPacketAccountOwnershipType = new DemandPacketAccountOwnershipType
                {
                    DemandPacket=demandPacket,
                    AccountOwnershipTypeId=(int)accountOwnershipType
                };
                demandPacketAccountOwnershipTypes.Add(demandPacketAccountOwnershipType);
            }
            foreach (var subscriptionType in request.SubscriptionTypes)
            {
                var demandPacketSubscriptionType = new DemandPacketSubscriptionType
                {
                    DemandPacket = demandPacket,
                    SubscriptionTypeId = (int)subscriptionType
                };
                demandPacketSubscriptionTypes.Add(demandPacketSubscriptionType);
            }
            demandPacket.DemandPacketAccountOwnershipTypes = demandPacketAccountOwnershipTypes;
            demandPacket.DemandPacketSubscriptionTypes = demandPacketSubscriptionTypes;
            var demandPacketId = await _demandPacketRepository.InsertAsync(demandPacket);
            return demandPacketId;
        }
        public async Task<DemandPacket> FindById(Guid id)
        {
            return await _demandPacketRepository.FindById(id);
        }
        public async Task SetDemandPacketStatus(SetDemandPacketStatusRequest request)
        {
            var demandPacket = await FindById(request.Id);
            demandPacket.DemandStatusId = (int)request.DemandStatusId;
            _demandPacketRepository.SetDemandPacketStatus(demandPacket);
        }
        #endregion

        #region Private Methods
        private async Task<ExecutDemandPacketStatus> DemandByNationalCode(ExecutDemandPacketRequest request, Guid demandPacketId)
        {

            var customerAccounts = await GetCustomerAccounts(request.Value);
            if (IsMatchSubscriptionType(customerAccounts.Accounts, request.SubscriptionTypes))
            {
                var accountsForBlock = customerAccounts.Accounts.Where(l => request.SubscriptionTypes.Contains(l.SubscriptionType)).ToList();
                foreach (var customerAccount in accountsForBlock)
                {
                    //var accountInfo = await GetAccountDetail(customerAccount.AccountNumber);
                    var accountInfo = await GetAccountDetail("3117112179449");

                    if (IsMatchAccountOwnershipType(accountInfo.OwnershipTypeId, request.AccountOwnershipTypes))
                    {
                        var accountId = await AddAccount(accountInfo, demandPacketId);
                        //var customerInfo = await GetCustomerInfo(request.Value);
                        foreach (var customerInfo in accountInfo.CustomerInfos)
                        {
                            await AddCustomer(accountInfo.CustomerInfos, accountId);
                        }
                        await SaveChanges();
                        var queueRequest = await GenerateBlockQueuesRequest(demandPacketId, accountId, accountInfo, request);
                        _queueProducer.SendMessage("BlockWithdraw", queueRequest);
                        _queueProducer.SendMessage("BlockAccount", queueRequest);
                    }
                    else
                    {
                        SetDemandStatusNoMatchedAccount(demandPacketId);
                        await SaveChanges();
                    }
                }
            }
            else
            {
                SetDemandStatusToNoAccount(demandPacketId);
                await SaveChanges();
            }
           return GenerateResponse();
        }

        private ExecutDemandPacketStatus GenerateResponse()
        {
            return ExecutDemandPacketStatus.Successful;
        }

        private bool IsMatchAccountOwnershipType(CustomerType ownershipTypeId, List<AccountOwnershipTypeEnum> accountOwnershipTypes)
        {
            AccountOwnershipTypeEnum ownershipType = MapOwnershipType(ownershipTypeId);
            if (accountOwnershipTypes.Contains(ownershipType))
            {
                return true;
            }
            return false;
        }

        private AccountOwnershipTypeEnum MapOwnershipType(CustomerType ownershipTypeId)
        {
            switch (ownershipTypeId)
            {
                case CustomerType.RealCustomer:
                    return AccountOwnershipTypeEnum.RealCustomer;
                case CustomerType.LegalCustomer:
                    return AccountOwnershipTypeEnum.LegalCustomer;
                case CustomerType.ForeignRealCustomer:
                    return AccountOwnershipTypeEnum.RealCustomer;
                case CustomerType.ForeignLegalCustomer:
                    return AccountOwnershipTypeEnum.LegalCustomer;
                default:
                    return AccountOwnershipTypeEnum.RealCustomer;
            }
        }

        private bool IsMatchSubscriptionType(List<CustomerAccount> accounts, List<SubscriptionTypeEnum> subscriptionTypes)
        {
            if (accounts.Any(x => subscriptionTypes.Any(y => y == x.SubscriptionType)))
            {
                return true;
            }
            return false;
        }

        private AddDemandPacketRequest GenerateAddDemandRequest(ExecutDemandPacketRequest request)
        {
            var demandPacketRequest = new AddDemandPacketRequest
            {
                BlockUnblockReason = request.BlockUnblockReason,
                AccountOwnershipTypes = request.AccountOwnershipTypes,
                TraceCode = request.TraceCode,
                LetterId = request.LetterId,
                Value = request.Value,
                BlockUnblockPassword = request.BlockUnblockPassword,
                SwiftType = request.SwiftType,
                DemandStatus = DemandStatusEnum.DoingTransaction,
                SubscriptionTypes = request.SubscriptionTypes,
            };
            return demandPacketRequest;
        }
        private async Task<GetAccountInfoResponse> GetAccountDetail(string accountNumber)
        {
            var request = new GetAccountInfoRequest
            {
                AccoutnNumberOrIBAN = accountNumber
            };
            return await _accountService.GetAccountInfo(request);
        }
        private async Task<GetCustomerAccountsResponse> GetCustomerAccounts(string nationalCode)
        {
            var request = new GetCustomerAccountsRequest
            {
                NationalCode = nationalCode
            };
            var customerAccounts = await _accountService.GetCustomerAccounts(request);
            return customerAccounts;
        }
        private async Task<Guid> AddAccount(GetAccountInfoResponse accountInfo, Guid demandPacketId)
        {
            var accountRequest = new AddAccountRequest
            {
                Number = accountInfo.Number,
                Iban = accountInfo.Iban,
                AvailableAmount = accountInfo.AvailableAmount,
                ActualAmount = accountInfo.ActualAmount,
                DemandPacketId = demandPacketId,
                TypeDescription = accountInfo.TypeDescription,
            };
            return await _accountService.Add(accountRequest);
        }

        private async Task AddCustomer(List<CustomerInfo> customerInfos, Guid accountId)
        {
            foreach (var customerInfo in customerInfos)
            {
                var customerRequest = new AddCustomerRequest
                {
                    FirstName = customerInfo.FirstName,
                    LastName = customerInfo.LastName,
                    NationalCode = customerInfo.NationalCode,
                    AccountId = accountId
                };
                await _customerService.Add(customerRequest);
            }
            
        }
        private async void SetDemandStatusNoMatchedAccount(Guid demandPacketId)
        {
            var request = new SetDemandPacketStatusRequest
            {
                Id = demandPacketId,
                DemandStatusId = DemandStatusEnum.NoMatchedAccount
            };
            await SetDemandPacketStatus(request);
        }
        private async void SetDemandStatusToNoAccount(Guid demandPacketId)
        {
            var request = new SetDemandPacketStatusRequest
            {
                Id = demandPacketId,
                DemandStatusId = DemandStatusEnum.NotExistAccount
            };
            await SetDemandPacketStatus(request);
        }
        private async Task SaveChanges()
        {
            await _unitOfWork.SaveChangesAsync();
        }
        private async Task<BlockQueueRequest> GenerateBlockQueuesRequest(Guid demandPacketId, Guid accountId, GetAccountInfoResponse accountInfo, ExecutDemandPacketRequest request)
        {
            var letter = await GetLetterById(request.LetterId);
            var queueRequest = new BlockQueueRequest
            {
                AccountId = accountId,
                DemandPacketId = demandPacketId,
                AccountNumber = accountInfo.Number,
                BlockReason = request.BlockUnblockReason,
                LetterContext = letter.Content,
                LetterDate = letter.Date,
                LetterDeadline = letter.Deadline,
                LetterNumber = letter.Number,
                LetterTitle = letter.Title,
                ReceiptLetterDate = letter.ReceiptDate,
                BlockUnblockPassword = request.BlockUnblockPassword,
                SwiftType = request.SwiftType,
                LetterContextImage = letter.ContextImage
            };
            return queueRequest;
        }
        private async Task<FindLetterByIdResponse> GetLetterById(Guid letterId)
        {
            var request = new FindLetterByIdRequest
            {
                LetterId = letterId
            };
            return await _letterService.FindLetterById(request);
        }


        #endregion
    }
}
