namespace AccountManagement.Contract.Dto
{
    public class GetAccountByDemandPacketIdResponse
    {
        public List<AccountDetail> Accounts { get; set; }
    }
    public class AccountDetail
    {
        public Guid Id { get; set; }
        public string Number { get; set; }
        public string Iban { get; set; }
        public double AvailableAmount { get; set; }
        public double ActualAmount { get; set; }
    }
}
