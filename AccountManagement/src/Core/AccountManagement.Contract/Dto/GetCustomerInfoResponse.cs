using AccountManagement.Contract.Enums;

namespace AccountManagement.Contract.Dto
{
    public class GetCustomerInfoResponse
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }
        public CustomerType CustomerType { get; set; }
    }
}
