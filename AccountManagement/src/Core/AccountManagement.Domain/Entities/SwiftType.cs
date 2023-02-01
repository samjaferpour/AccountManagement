namespace AccountManagement.Domain.Entities
{
    public class SwiftType
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }
        public IEnumerable<DemandPacket> DemandPackets { get; set; }
    }
}
