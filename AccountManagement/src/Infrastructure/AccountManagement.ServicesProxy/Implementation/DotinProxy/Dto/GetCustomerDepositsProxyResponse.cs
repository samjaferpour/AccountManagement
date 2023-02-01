using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AccountManagement.ServicesProxy.Implementation.DotinProxy.Dto
{
    public class GetCustomerDepositsProxyResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public int RsCode { get; set; }
        public List<CustomerDeposits> ResultData { get; set; }
    }
    public class CustomerDeposits
    {
        public string DepositNumber { get; set; }
        public string MainCustomerNumber { get; set; }
        public string DepositTitle { get; set; }
        public string DepositTypeNumber { get; set; }
        public string DepositTypeTitle { get; set; }
        public string CustomerRelationWithDepositPersian { get; set; }
        public string CustomerRelationWithDepositEnglish { get; set; }
        public string DepositState { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencySwiftCode { get; set; }
        public string WithdrawRight { get; set; }
        public string BranchCode { get; set; }
        public string DepositIban { get; set; }
        public string Portion { get; set; }
        public string IsSpecial { get; set; }
        public string FullName { get; set; }
        public string IndividualOrSharedDeposit { get; set; }
        public string OpeningDate { get; set; }
        public bool IsLongTerm { get; set; }
    }

}
