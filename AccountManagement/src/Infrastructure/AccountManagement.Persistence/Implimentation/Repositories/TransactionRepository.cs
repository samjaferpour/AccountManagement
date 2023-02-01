using AccountManagement.Contract.Interfaces.Repositories;
using AccountManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Persistence.Implimentation.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly AccountManagementDbContext _dbcontext;

        public TransactionRepository(AccountManagementDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<Guid> InsertAsync(Transaction transaction)
        {
            await _dbcontext.Transactions.AddAsync(transaction);
            return transaction.Id;
        }
        public async Task<Transaction> FindById(Guid id)
        {
            var transaction = await _dbcontext.Transactions
                           .FirstOrDefaultAsync(p => p.Id == id);
            return transaction;
        }
        public void Update(Transaction transaction)
        {
             _dbcontext.Transactions.Update(transaction);
        }


    }
}
