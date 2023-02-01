using AccountManagement.Domain.Enums;

namespace AccountManagement.Contract.Dto
{
    public class GetCustomerAccountsResponse
    {
        public List<CustomerAccount> Accounts { get; set; }
    }
    public class CustomerAccount
    {
        public string CreatorBranchCode { get; set; }
        public string AccountNumber { get; set; }
        public string AccountTypeTitle { get; set; }
        public string OpeningDate { get; set; }
        public string AccountState { get; set; }
        public string WithdrawRight { get; set; }
        public string AccountIban { get; set; }
        public SubscriptionTypeEnum SubscriptionType { get; set; }
    }
}
