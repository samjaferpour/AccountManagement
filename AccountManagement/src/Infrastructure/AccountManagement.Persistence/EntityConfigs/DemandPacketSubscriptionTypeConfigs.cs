using AccountManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Persistence.EntityConfigs
{
    public class DemandPacketSubscriptionTypeConfigs : IEntityTypeConfiguration<DemandPacketSubscriptionType>
    {
        public void Configure(EntityTypeBuilder<DemandPacketSubscriptionType> builder)
        {
            builder.HasKey(sc => new { sc.SubscriptionTypeId, sc.DemandPacketId });

            builder.HasOne(sc => sc.DemandPacket)
                .WithMany(s => s.DemandPacketSubscriptionTypes)
                .HasForeignKey(sc => sc.DemandPacketId);

            builder.HasOne(sc => sc.SubscriptionType)
                .WithMany(s => s.DemandPacketSubscriptionTypes)
                .HasForeignKey(sc => sc.SubscriptionTypeId);

        }
    }
}
