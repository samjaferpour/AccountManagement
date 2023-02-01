using AccountManagement.Domain.Entities;

namespace AccountManagement.Contract.Dto
{
    public class AddAccountRequest
    {
        public string Number { get; set; }
        public string Iban { get; set; }
        public double AvailableAmount { get; set; }
        public double ActualAmount { get; set; }
        public Guid DemandPacketId { get; set; }
        public string TypeDescription { get; set; }
    }
}
