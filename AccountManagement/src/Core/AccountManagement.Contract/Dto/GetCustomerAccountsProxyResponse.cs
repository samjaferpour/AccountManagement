using AccountManagement.Contract.Enums;
using AccountManagement.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Contract.Dto
{
    public class GetCustomerAccountsProxyResponse
    {
        public List<CustomerAccountProxy> Accounts { get; set; }
    }
    public class CustomerAccountProxy
    {
        public string CreatorBranchCode { get; set; }
        public string AccountNumber { get; set; }
        public string AccountTypeTitle { get; set; }
        public string OpeningDate { get; set; }
        public string AccountState { get; set; }
        public string WithdrawRight { get; set; }
        public string AccountIban { get; set; }
        public SubscriptionTypeEnum SubscriptionType { get; set;}
    }
}
