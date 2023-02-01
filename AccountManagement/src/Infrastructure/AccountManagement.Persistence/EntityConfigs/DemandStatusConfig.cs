using AccountManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Persistence.EntityConfigs
{
    public class DemandStatusConfig : IEntityTypeConfiguration<DemandStatus>
    {
        public void Configure(EntityTypeBuilder<DemandStatus> builder)
        {
            builder.HasMany(x => x.DemandPackets)
                .WithOne(x => x.DemandStatus);
        }

        
    }
}
