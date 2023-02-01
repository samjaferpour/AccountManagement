using AccountManagement.Domain.Enums;

namespace AccountManagement.Contract.Dto
{
    public class AddTransactionRequest
    {
        public int? AccountBlockingStatusCode { get; set; }
        public string AccountBlockingStatusDescription { get; set; }
        public string AccountBlockingTraceNumber { get; set; }
        public string AccountBlockingDate { get; set; }
        public int? WithdrawBlockingStatusCode { get; set; }
        public string WithdrawBlockingStatusDescription { get; set; }
        public string WithdrawBlockingTraceNumber { get; set; }
        public string WithdrawBlockingDate { get; set; }
        public Guid AccountId { get; set; }
    }
}
