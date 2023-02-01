using AccountManagement.Contract.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Persistence.Implimentation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AccountManagementDbContext _dbcontext;

        public UnitOfWork(AccountManagementDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public async Task<int> SaveChangesAsync()
        {
            return await _dbcontext.SaveChangesAsync();
        }
        public void Dispose()
        {
            _dbcontext.Dispose();
        }
    }
}
