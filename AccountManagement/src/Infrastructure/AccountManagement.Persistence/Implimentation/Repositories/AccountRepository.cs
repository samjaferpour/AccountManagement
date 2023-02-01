using AccountManagement.Contract.Dto;
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
    public class AccountRepository : IAccountRepository
    {
        private readonly AccountManagementDbContext _dbcontext;

        public AccountRepository(AccountManagementDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<List<AccountOwnershipType>> AccountOwnershipTypeAsync()
        {
            var data = await _dbcontext.AccountOwnershipType
                .OrderBy(o => o.Order)
                .ToListAsync();
            return data;
        }

        public async Task<List<SubscriptionType>> GetSubscriptionTypeAsync()
        {
            var subscriptionData= await _dbcontext.SubscriptionTypes
                .OrderBy(o => o.Order)
                .ToListAsync();
            return subscriptionData;
        }

        public async Task<Guid> InsertAsync(Account account)
        {
            await _dbcontext.Accounts.AddAsync(account);
            return account.Id;
        }
        public async Task<List<Account>> GetAccountsByDemandPacketId(Guid demandPacketId)
        {
            var accounts = await _dbcontext.Accounts
                                .Where(p => p.DemandPacketId == demandPacketId)
                                .ToListAsync();
            return accounts;
        }
        public async Task<List<SwiftType>> GetSwiftTypesAsync()
        {
            var swiftTypes = await _dbcontext.SwiftTypes
                .OrderBy(o => o.Order)
                .ToListAsync();
            return swiftTypes;
        }
}
}
