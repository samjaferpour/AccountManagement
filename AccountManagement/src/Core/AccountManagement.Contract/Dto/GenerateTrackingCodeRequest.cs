using AccountManagement.Domain.Enums;


namespace AccountManagement.Contract.Dto
{
    public class GenerateTrackingCodeRequest
    {
        public string LetterTitle { get; set; }
        public string LetterContent { get; set; }
        public string LetterNumber { get; set; }
        public string LetterDate { get; set; }
        public string Deadline { get; set; }
        public string? ReceiptDate { get; set; }
        public LetterTypeEnum LetterType { get; set; }
        public string? ContextImage { get; set; }
        public List<DemandItem> DemandItems { get; set; }
    }
    public class DemandItem
    {
        public Guid TraceCode { get; set; }
        public string Value { get; set; }
        public string? BlockUnblockPassword { get; set; }
        public BlockUnblockReasonEnum BlockUnblockReasonId { get; set; }
        public List<AccountOwnershipTypeEnum> AccountOwnershipTypeIds { get; set; }
        public List<SubscriptionTypeEnum> SubscriptionTypeIds { get; set; }
        public SwiftTypeEnum SwiftTypeId { get; set; }

    }
}
