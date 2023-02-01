using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Domain.Entities
{
    public class Account
    {
        public Guid Id { get; set; }
        public string Number { get; set; }
        public string Iban { get; set; }
        public double AvailableAmount { get; set; }
        public double ActualAmount { get; set; }
        public string TypeDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid CreatorId { get; set; }
        public Guid DemandPacketId { get; set; }
        public DemandPacket DemandPacket { get; set; }
        public WithdrawAccountTransaction WithdrawAccountTransaction { get; set; }
        public BlockAccountTransaction BlockAccountTransaction { get; set; }
        public IEnumerable<Customer> Customers { get; set; }
    }
}
