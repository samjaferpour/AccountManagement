using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Domain.Entities
{
    public class DemandPacketAccountOwnershipType
    {
        public Guid DemandPacketId { get; set; }
        public DemandPacket DemandPacket { get; set; }

        public int AccountOwnershipTypeId { get; set; }
        public AccountOwnershipType AccountOwnershipType { get; set; }
    }
}
