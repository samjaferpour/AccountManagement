namespace AccountManagement.Contract.Dto
{
    public class GetWithdrawTransactionByAccountIdResponse
    {
        public int Status { get; set; }
        public string Description { get; set; }
        public string TraceNumber { get; set; }
        public string Date { get; set; }
    }
}
