namespace AccountManagement.Contract.Dto
{
    public class BlockWithdrawResponse
    {
        public string TraceNumber { get; set; }
        public string TransactionDate { get; set; }
        public bool IsSuccess { get; set; }
        public int StatusCode { get; set; }
        public string Message { get; set; }
    }
}
