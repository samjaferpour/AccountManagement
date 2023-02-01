using AccountManagement.Contract.Dto;

namespace AccountManagement.Contract.Interfaces.Services
{
    public interface IAccountService
    {
        Task<Guid> Add(AddAccountRequest request);
        Task<GetAccountOwnershipTypeResponse> GetAccountOwnershipTypes();
        Task<GetSubscriptionTypesResponse> GetSubscriptionTypes();
        Task<GetCustomerAccountsResponse> GetCustomerAccounts(GetCustomerAccountsRequest request);
        Task<GetAccountInfoResponse> GetAccountInfo(GetAccountInfoRequest request);
        Task<GetAccountByDemandPacketIdResponse> GetAccountsByDemandPacketId(GetAccountByDemandPacketIdRequest request);
        Task<GetSwiftTypesResponse> GetSwiftTypes();
    }
}
