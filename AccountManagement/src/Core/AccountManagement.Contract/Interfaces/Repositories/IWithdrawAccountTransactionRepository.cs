using AccountManagement.Domain.Entities;

namespace AccountManagement.Contract.Interfaces.Repositories
{
    public interface IWithdrawAccountTransactionRepository
    {
        Task<Guid> Add(WithdrawAccountTransaction transaction);
        Task<WithdrawAccountTransaction> FindByAccountId(Guid accountId);
    }
}
