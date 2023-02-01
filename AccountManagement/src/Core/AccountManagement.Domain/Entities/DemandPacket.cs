

namespace AccountManagement.Domain.Entities
{
    public class DemandPacket
    {
        public Guid Id { get; set; }
        public Guid LetterId { get; set; }
        public Guid TraceCode { get; set; }
        public string Value { get; set; }
        public string? BlockUnblockPassword { get; set; }
        public int BlockUnblockReasonId { get; set; }
        public int DemandStatusId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid CreatorId { get; set; }
        public int SwiftTypeId { get; set; }
        public SwiftType SwiftType { get; set; }
        public BlockUnblockReason BlockUnblockReason { get; set; }
        public DemandStatus DemandStatus { get; set; }
        public Letter Letter { get; set; }
        public IEnumerable<Account> Accounts { get; set; }
        public IEnumerable<DemandPacketSubscriptionType> DemandPacketSubscriptionTypes { get; set; }
        public IEnumerable<DemandPacketAccountOwnershipType> DemandPacketAccountOwnershipTypes { get; set; }
    }
}
