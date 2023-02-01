using AccountManagement.Domain.Enums;

namespace AccountManagement.Contract.Dto
{
    public class AddDemandPacketRequest
    {
        public Guid LetterId { get; set; }
        public Guid TraceCode { get; set; }
        public string Value { get; set; }
        public string? BlockUnblockPassword { get; set; }
        public BlockUnblockReasonEnum BlockUnblockReason { get; set; }
        public List<AccountOwnershipTypeEnum> AccountOwnershipTypes { get; set; }
        public DemandStatusEnum DemandStatus { get; set; }
        public List<SubscriptionTypeEnum> SubscriptionTypes { get; set; }
        public SwiftTypeEnum SwiftType { get; set; }
    }
}
