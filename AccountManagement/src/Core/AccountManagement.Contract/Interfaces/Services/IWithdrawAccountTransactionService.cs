using AccountManagement.Contract.Dto;

namespace AccountManagement.Contract.Interfaces.Services
{
    public interface IWithdrawAccountTransactionService
    {
        Task<Guid> Add(AddWithdrawAccountTransactionRequest request);
        Task<GetWithdrawTransactionByAccountIdResponse> GetByAccountId(GetWithdrawTransactionByAccountIdRequest request);
    }
}
