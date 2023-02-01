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
    public class DemandPacketAccountOwnershipTypeConfigs : IEntityTypeConfiguration<DemandPacketAccountOwnershipType>
    {
        public void Configure(EntityTypeBuilder<DemandPacketAccountOwnershipType> builder)
        {
            builder.HasKey(sc => new { sc.AccountOwnershipTypeId, sc.DemandPacketId });

            builder.HasOne(sc => sc.DemandPacket)
                .WithMany(s => s.DemandPacketAccountOwnershipTypes)
                .HasForeignKey(sc => sc.DemandPacketId);

            builder.HasOne(sc => sc.AccountOwnershipType)
                .WithMany(s => s.DemandPacketAccountOwnershipTypes)
                .HasForeignKey(sc => sc.AccountOwnershipTypeId);

        }
    }
}
