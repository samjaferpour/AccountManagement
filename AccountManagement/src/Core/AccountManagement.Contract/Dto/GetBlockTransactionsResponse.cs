namespace AccountManagement.Contract.Dto
{
    public class GetBlockTransactionsResponse
    {
        public Guid TrackingCode { get; set; }
        public IEnumerable<DemandItemDto> DemandItems { get; set; }
    }

    public class DemandItemDto
    {
        public Guid TraceCode { get; set; }
        public IEnumerable<AccountTransaction> AccountTransaction { get; set; }
        public int DemandStatus { get; set; }
        public string DemandStatusTitle { get; set; }
    }
    public class AccountTransaction
    {
        public IEnumerable<CustomerDto> Customers { get; set; }
        public string AccountNumber { get; set; }
        public string Iban { get; set; }
        public string AccountType { get; set; }
        public double AvailableAmount { get; set; }
        public double ActualAmount { get; set; }
        public BlockAccountTransactionDto BlockAccountTransaction { get; set; }
        public WithdrawAccountTransactionDto WithdrawAccountTransaction { get; set; }
    }
    public class CustomerDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }
    }
    public class BlockAccountTransactionDto
    {
        public string TraseNumber { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
    }
    public class WithdrawAccountTransactionDto
    {
        public string TraseNumber { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
    }
}
