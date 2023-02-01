using AccountManagement.Domain.Enums;

namespace AccountManagement.Contract.Dto
{
    public class SetDemandPacketStatusRequest
    {
        public Guid Id { get; set; }
        public DemandStatusEnum DemandStatusId { get; set; }
    }
}
