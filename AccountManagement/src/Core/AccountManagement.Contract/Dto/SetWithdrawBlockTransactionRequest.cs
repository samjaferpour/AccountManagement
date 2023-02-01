namespace AccountManagement.Contract.Dto
{
    public class SetWithdrawBlockTransactionRequest
    {
        public Guid Id { get; set; }
        public int? WithdrawBlockingStatusCode { get; set; }
        public string WithdrawBlockingStatusDescription { get; set; }
        public string WithdrawBlockingTraceNumber { get; set; }
        public string WithdrawBlockingDate { get; set; }
    }
}
