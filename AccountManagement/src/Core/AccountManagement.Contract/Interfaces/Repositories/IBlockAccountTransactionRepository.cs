using AccountManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Contract.Interfaces.Repositories
{
    public interface IBlockAccountTransactionRepository
    {
        Task<Guid> Add(BlockAccountTransaction transaction);
        Task<BlockAccountTransaction> FindByAccountId(Guid accountId);
    }
}
