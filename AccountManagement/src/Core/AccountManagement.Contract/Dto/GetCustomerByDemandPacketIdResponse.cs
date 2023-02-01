namespace AccountManagement.Contract.Dto
{
    public class GetCustomerByDemandPacketIdResponse
    {
        public List<CustomerDetial> Customers { get; set; }
        
    }
    public class CustomerDetial
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }
    }
}
