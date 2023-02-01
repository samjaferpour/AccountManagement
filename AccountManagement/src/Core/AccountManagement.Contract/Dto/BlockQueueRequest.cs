using AccountManagement.Domain.Enums;

namespace AccountManagement.Contract.Dto
{
    public class BlockQueueRequest
    {
        public Guid AccountId { get; set; }
        public Guid DemandPacketId { get; set; }
        public string AccountNumber { get; set; }
        public string ReceiptLetterDate { get; set; }
        public string LetterTitle { get; set; }
        public string LetterContext { get; set; }
        public string LetterNumber { get; set; }
        public string LetterDate { get; set; }
        public string LetterDeadline { get; set; }
        public string? LetterContextImage { get; set; }
        public string? BlockUnblockPassword { get; set; }
        public BlockUnblockReasonEnum BlockReason { get; set; }
        public SwiftTypeEnum SwiftType { get; set; }
    }
}
