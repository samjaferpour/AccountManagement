using AccountManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace AccountManagement.Persistence.EntityConfigs
{
    public class BlockUnblockReasonTypeConfig : IEntityTypeConfiguration<BlockUnblockReason>
    {
        public void Configure(EntityTypeBuilder<BlockUnblockReason> builder)
        {
            builder.HasMany(x => x.DemandPackets)
                .WithOne(x => x.BlockUnblockReason);
        }

        
    }
}
