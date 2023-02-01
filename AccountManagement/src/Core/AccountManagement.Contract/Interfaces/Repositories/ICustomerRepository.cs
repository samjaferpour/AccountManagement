using AccountManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Contract.Interfaces.Repositories
{
    public interface ICustomerRepository
    {
        Task InsertAsync(Customer customer);
        Task<List<Customer>> FindByAccountId(Guid accountId);
    }
}
