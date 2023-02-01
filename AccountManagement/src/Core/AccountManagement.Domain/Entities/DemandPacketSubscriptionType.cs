using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Domain.Entities
{
    public class DemandPacketSubscriptionType
    {
        public Guid DemandPacketId { get; set; }
        public DemandPacket DemandPacket { get; set; }

        public int SubscriptionTypeId { get; set; }
        public SubscriptionType SubscriptionType { get; set; }
    }
}
