namespace AccountManagement.Contract.Dto
{
    public class AddCustomerRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public String NationalCode { get; set; }
        public Guid AccountId { get; set; }
    }
}
