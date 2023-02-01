using AccountManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace AccountManagement.Persistence.EntityConfigs
{
    public class DemandPacketConfigs : IEntityTypeConfiguration<DemandPacket>
    {
        public void Configure(EntityTypeBuilder<DemandPacket> builder)
        {
            builder.HasKey(k => k.Id);
            builder.Property(p => p.CreatedDate).HasDefaultValue(DateTime.Now);
            builder.Property(p => p.ModifiedDate).HasDefaultValue(DateTime.Now);
            builder.Property(p => p.Value).IsRequired();
            builder.Property(p => p.TraceCode).IsRequired();

            builder.HasOne(t => t.Letter)
                   .WithMany(t => t.DemandPackets)
                   .HasForeignKey(t => t.LetterId);

            builder.HasOne(t => t.BlockUnblockReason)
                   .WithMany(t => t.DemandPackets)
                   .HasForeignKey(p => p.BlockUnblockReasonId);

            builder.HasOne(t => t.DemandStatus)
                   .WithMany(t => t.DemandPackets)
                   .HasForeignKey(p => p.DemandStatusId);

            builder.HasOne(s => s.SwiftType)
                  .WithMany(s => s.DemandPackets)
                  .HasForeignKey(s => s.SwiftTypeId);


        }
    }

}

