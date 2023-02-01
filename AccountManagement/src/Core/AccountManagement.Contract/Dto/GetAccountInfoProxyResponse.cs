using AccountManagement.Contract.Enums;
using AccountManagement.Domain.Enums;

namespace AccountManagement.Contract.Dto
{
    public class GetAccountInfoProxyResponse
    {
        public string Number { get; set; }
        public string BackupAccountNumber { get; set; }
        public string Iban { get; set; }
        public string CreateDate { get; set; }
        public string CreatorBranchCode { get; set; }
        public string SharePercent { get; set; }
        public BankAccountStatus Status { get; set; }
        public string TypeDescription { get; set; }
        public CustomerType OwnershipTypeId { get; set; }
        public double AvailableAmount { get; set; }
        public double ActualAmount { get; set; }
        public List<CustomerInfoProxy> CustomerInfoProxys { get; set; }
    }
    public class CustomerInfoProxy
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }
        public CustomerType CustomerType { get; set; }
    }
}
