using AccountManagement.Domain.Enums;

namespace AccountManagement.Contract.Dto
{
    public class SetAccountBlockTransactionRequest
    {
        public Guid Id { get; set; }
        public int? AccountBlockingStatusCode { get; set; }
        public string AccountBlockingStatusDescription { get; set; }
        public string AccountBlockingTraceNumber { get; set; }
        public string AccountBlockingDate { get; set; }
    }
}
