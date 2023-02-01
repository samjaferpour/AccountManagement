using AccountManagement.Contract.Dto;
using AccountManagement.Contract.Enums;
using AccountManagement.Contract.Interfaces.Proxy;
using AccountManagement.Contract.Interfaces.Repositories;
using AccountManagement.Contract.Interfaces.Services;
using AccountManagement.Domain.Enums;
using AccountManagement.Framework.ApiResult;

namespace AccountManagement.Service.Services
{
    public class AccountManagementService : IAccountManagementService
    {
        private readonly IBlockAccountTransactionService _blockAccountTransactionService;
        private readonly IWithdrawAccountTransactionService _withdrawAccountTransactionService;
        private readonly IDemandPacketService _demandPacketService;
        private readonly IDotinProxy _dotinProxy;
        private readonly IUnitOfWork _unitOfWork;

        private readonly IBlockUnblockReasonRepository _blockUnblockReasonRepository;
        


        public AccountManagementService(IBlockAccountTransactionService blockAccountTransactionService,
                                        IWithdrawAccountTransactionService withdrawAccountTransactionService,
                                        IDemandPacketService demandPacketService,
                                        IDotinProxy dotinProxy,
                                        IUnitOfWork unitOfWork,
                                        IBlockUnblockReasonRepository blockUnblockreasonRepository)
        {
            _blockAccountTransactionService = blockAccountTransactionService;
            _withdrawAccountTransactionService = withdrawAccountTransactionService;
            _demandPacketService = demandPacketService;
            _dotinProxy = dotinProxy;
            _unitOfWork = unitOfWork;
            _blockUnblockReasonRepository = blockUnblockreasonRepository;
        }
        #region Public Methods
        public async Task<GetBlockUnblockReasonResponse> GetBlockUnblockReasonListAsync()
        {
            var blockUnblockReasonList = await _blockUnblockReasonRepository.GetBlockUnblockReasonsAsync();
            List<BlockUnblockReasonItem> BlockUnblockReasonItems = new List<BlockUnblockReasonItem>();
            GetBlockUnblockReasonResponse response = new GetBlockUnblockReasonResponse();

            foreach (var item in blockUnblockReasonList)
            {
                BlockUnblockReasonItems.Add(new BlockUnblockReasonItem { Code = item.Id, Title = item.Title });
            }
            response.BlockUnblockReasonItems = BlockUnblockReasonItems;

            return response;
        }
        public async Task<BlockAccountStatus> BlockAccount(BlockAccountRequest request)
        {
            var blockAccountProxyResult = await BlockAccountProxy(request);
            await AddBlockAccountTransaction(request.AccountId, blockAccountProxyResult);
            await SetDemandStatusDoneTransaction(request.DemandPacketId);
            await SaveChanges();
            return GenerateResponse(blockAccountProxyResult);
        }
        public async Task<BlockWithdrawStatus> BlockWithdraw(BlockWithdrawRequest request)
        {
            var blockWithdrawProxyResult = await BlockWithdrawProxy(request);
            await AddWithdrawAccountTransaction(request.AccountId, blockWithdrawProxyResult);
            await SetDemandStatusDoneTransaction(request.DemandPacketId);
            await SaveChanges();

            return GenerateResponse(blockWithdrawProxyResult);
        }

        #endregion

        #region Private Methods
        private async Task SetDemandStatusDoneTransaction(Guid demandPacketId)
        {
            var request = new SetDemandPacketStatusRequest
            {
                Id = demandPacketId,
                DemandStatusId = DemandStatusEnum.DoneTransaction
            };
            await _demandPacketService.SetDemandPacketStatus(request);
        }
        private async Task AddWithdrawAccountTransaction(Guid accountId, ActionResult<BlockWithdrawProxyResponse> blockInfo)
        {
            var request = new AddWithdrawAccountTransactionRequest
            {
                //ToDo: زمانی که یک جدول برای پیغام ها تعریف کردم اینها تغییر میکنه و وردی متد هم دیگه از این نوع نیست
                Status = blockInfo.StatusCode,
                Description = blockInfo.Message,
                TraceNumber = blockInfo.Data.TraceNumber,
                Date = blockInfo.Data.TransactionDate,
                AccountId = accountId,
            };
            await _withdrawAccountTransactionService.Add(request);
        }

        private BlockWithdrawStatus GenerateResponse(ActionResult<BlockWithdrawProxyResponse> blockInfo)
        {
            //اینجا باید همه استتوس های مربوط به داتین رو چک کنم که بر اساس اونها بگم کدوما دوباره ریترای بشه
            if (blockInfo.IsSuccess)
            {
                return BlockWithdrawStatus.Successful;
            }
            return BlockWithdrawStatus.Unsuccessful;
        }

        private BlockAccountStatus GenerateResponse(ActionResult<BlockAccountProxyResponse> blockInfo)
        {
            //اینجا باید همه استتوس های مربوط به داتین رو چک کنم که بر اساس اونها بگم کدوما دوباره ریترای بشه
            if (blockInfo.IsSuccess)
            {
                return BlockAccountStatus.Successful;
            }
            if (blockInfo.StatusCode== 401)
            {
                return BlockAccountStatus.Retry;
            }
            return BlockAccountStatus.Unsuccessful;

        }

        private async Task AddBlockAccountTransaction(Guid accountId, ActionResult<BlockAccountProxyResponse> blockInfo)
        {
            var request = new AddBlockAccountTransactionRequest
            {
                AccountId = accountId,
                //ToDo: زمانی که یک جدول برای پیغام ها تعریف کردم اینها تغییر میکنه و وردی متد هم دیگه از این نوع نیست
                Status = blockInfo.StatusCode,
                Description = blockInfo.Message,
                TraceNumber = blockInfo.Data.TraceNumber,
                Date = blockInfo.Data.TransactionDate
            };
            await _blockAccountTransactionService.Add(request);
        }
        private async Task<ActionResult<BlockAccountProxyResponse>> BlockAccountProxy(BlockAccountRequest request)
        {
            var requset = new BlockAccountProxyRequest
            {
                AccountNumber = request.AccountNumber,
                BlockReasonTitle = request.BlockReason.ToString(),
                LetterContext = request.LetterContext,
                LetterDate = request.LetterDate,
                LetterDeadline = request.LetterDeadline,
                LetterNumber = request.LetterNumber,
                LetterTitle = request.LetterTitle,
                ReceiptLetterDate = request.ReceiptLetterDate,
                BlockOrUnblockPasword = request.BlockUnblockPassword,
                LetterContextImage = request.LetterContextImage,
                SwiftCode=request.SwiftType.ToString()
            };
            var blockResult = await _dotinProxy.BlockAccount(requset);

            //ToDo: اینجا حتما خروجی چک بشه که اگر خروجی موفق نبود تو یه جدول ذخیره بشه
            return blockResult;
        }
        private async Task<ActionResult<BlockWithdrawProxyResponse>> BlockWithdrawProxy(BlockWithdrawRequest request)
        {
            var requset = new BlockWithdrawProxyRequest
            {
                AccountNumber = request.AccountNumber,
                BlockReasonTitle = request.BlockReason.ToString(),
                LetterContext = request.LetterContext,
                LetterDate = request.LetterDate,
                LetterDeadline = request.LetterDeadline,
                LetterNumber = request.LetterNumber,
                LetterTitle = request.LetterTitle,
                ReceiptLetterDate = request.ReceiptLetterDate,
                BlockOrUnblockPasword = request.BlockUnblockPassword,
                LetterContextImage = request.LetterContextImage,
                SwiftCode = request.SwiftType.ToString()

            };
            var blockResult = await _dotinProxy.BlockWithdraw(requset);

            //ToDo: اینجا حتما خروجی چک بشه که اگر خروجی موفق نبود تو یه جدول ذخیره بشه
            return blockResult;
        }
        private async Task SaveChanges()
        {
            await _unitOfWork.SaveChangesAsync();
        }


        #endregion
    }
}
