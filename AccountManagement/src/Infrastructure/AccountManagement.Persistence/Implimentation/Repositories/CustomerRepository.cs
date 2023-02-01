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
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AccountManagementDbContext _dbcontext;

        public CustomerRepository(AccountManagementDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task InsertAsync(Customer customer)
        {
            await _dbcontext.Customers.AddAsync(customer);
        }
        public async Task<List<Customer>> FindByAccountId(Guid accountId)
        {
            var customers = await _dbcontext.Customers
                                .Where(p => p.AccountId == accountId)
                                .ToListAsync();
            return customers;
        }

    }

}
