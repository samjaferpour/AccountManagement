
namespace AccountManagement.Domain.Entities
{
    public class Letter
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Number { get; set; }
        public string Date { get; set; }
        public string ReceiptDate { get; set; }
        public string Content { get; set; }
        public string Deadline { get; set; }
        public string? ContextImage { get; set; }
        public int DemandCount { get; set; }
        public Guid TrackingCode { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid CreatorId { get; set; }
        public int LetterTypeId { get; set; }
        public LetterType LetterType { get; set; }
        public IEnumerable<DemandPacket> DemandPackets { get; set; }

    }
}
