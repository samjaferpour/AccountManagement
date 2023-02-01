using AccountManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace AccountManagement.Persistence.EntityConfigs
{
    public class SwiftTypeConfig : IEntityTypeConfiguration<SwiftType>
    {
        public void Configure(EntityTypeBuilder<SwiftType> builder)
        {
            builder.HasMany(x => x.DemandPackets)
                   .WithOne(x => x.SwiftType);
        }
    }
}
