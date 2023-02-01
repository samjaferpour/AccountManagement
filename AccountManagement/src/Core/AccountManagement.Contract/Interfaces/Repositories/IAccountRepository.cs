using AccountManagement.Contract.Dto;
using AccountManagement.Domain.Entities;

namespace AccountManagement.Contract.Interfaces.Repositories
{
    public interface IAccountRepository
    {
        Task<Guid> InsertAsync(Account Account);
        Task<List<AccountOwnershipType>> AccountOwnershipTypeAsync();
        Task<List<SubscriptionType>> GetSubscriptionTypeAsync();
        Task<List<Account>> GetAccountsByDemandPacketId(Guid demandPacketId);
        Task<List<SwiftType>> GetSwiftTypesAsync();
    }
}
