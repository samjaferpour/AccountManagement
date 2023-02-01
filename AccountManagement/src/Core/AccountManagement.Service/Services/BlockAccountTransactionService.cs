using AccountManagement.Contract.Dto;
using AccountManagement.Contract.Interfaces.Repositories;
using AccountManagement.Contract.Interfaces.Services;
using AccountManagement.Domain.Entities;

namespace AccountManagement.Service.Services
{
    public class BlockAccountTransactionService: IBlockAccountTransactionService
    {
        private readonly IBlockAccountTransactionRepository _repository;
        public BlockAccountTransactionService(IBlockAccountTransactionRepository repository)
        {
            _repository = repository;
        }

        public async Task<Guid> Add(AddBlockAccountTransactionRequest request)
        {
            var transaction = new BlockAccountTransaction
            {
                AccountId = request.AccountId,
                Status = request.Status,
                TraceNumber = request.TraceNumber,
                Description= request.Description,
                Date = request.Date,
            };
            var transactionId = await _repository.Add(transaction);
            return transactionId;
        }
        public async Task<GetBlockTransactionByAccountIdResponse> GetByAccountId(GetBlockTransactionByAccountIdRequest request)
        {
            var transaction = await _repository.FindByAccountId(request.AccountId);
            return new GetBlockTransactionByAccountIdResponse
            {
                Date=transaction.Date,
                Description=transaction.Description,
                Status= transaction.Status,
                TraceNumber = transaction.TraceNumber   
            };
        }
    }
}
