using AccountManagement.Contract.Interfaces.Repositories;
using AccountManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AccountManagement.Persistence.Implimentation.Repositories
{
    public class WithdrawAccountTransactionRepository : IWithdrawAccountTransactionRepository
    {
        private readonly AccountManagementDbContext _dbcontext;

        public WithdrawAccountTransactionRepository(AccountManagementDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<Guid> Add(WithdrawAccountTransaction transaction)
        {
            await _dbcontext.WithdrawAccountTransactions.AddAsync(transaction);
            return transaction.Id;
        }
        public async Task<WithdrawAccountTransaction> FindByAccountId(Guid accountId)
        {
            var withdrawAccountTransaction = await _dbcontext.WithdrawAccountTransactions.FirstOrDefaultAsync(p => p.AccountId == accountId);
            return withdrawAccountTransaction;
        }
    }
}
