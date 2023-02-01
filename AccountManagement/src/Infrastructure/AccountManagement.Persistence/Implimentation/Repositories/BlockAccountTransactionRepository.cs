using AccountManagement.Contract.Interfaces.Repositories;
using AccountManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AccountManagement.Persistence.Implimentation.Repositories
{
    public class BlockAccountTransactionRepository: IBlockAccountTransactionRepository
    {
        private readonly AccountManagementDbContext _dbcontext;

        public BlockAccountTransactionRepository(AccountManagementDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<Guid> Add(BlockAccountTransaction transaction)
        {
            await _dbcontext.BlockAccountTransactions.AddAsync(transaction);
            return transaction.Id;
        }
        public async Task<BlockAccountTransaction> FindByAccountId(Guid accountId)
        {
            var blockAccountTransaction = await _dbcontext.BlockAccountTransactions.FirstOrDefaultAsync(p => p.AccountId == accountId);
            return blockAccountTransaction;
        }
    }
}
