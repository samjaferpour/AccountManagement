using AccountManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Contract.Interfaces.Repositories
{
    public interface ITransactionRepository
    {
        Task<Guid> InsertAsync(Transaction transaction);
        Task<Transaction> FindById(Guid id);
        void Update(Transaction transaction);
    }
}
