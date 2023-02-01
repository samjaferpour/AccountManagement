using AccountManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Persistence.EntityConfigs;

public class AccountConfigs : IEntityTypeConfiguration<Account>
{
    public void Configure(EntityTypeBuilder<Account> builder)
{
    builder.HasKey(k => k.Id);
    builder.Property(p => p.CreatedDate).HasDefaultValue(DateTime.Now);
    builder.Property(p => p.ModifiedDate).HasDefaultValue(DateTime.Now);
    builder.Property(p => p.Number).IsRequired();
    builder.Property(p => p.AvailableAmount).IsRequired();
    builder.Property(p => p.ActualAmount).IsRequired();
    builder.Property(p => p.DemandPacketId).IsRequired();

    builder.HasOne(t => t.DemandPacket)
                   .WithMany(t => t.Accounts)
                   .HasForeignKey(t => t.DemandPacketId);

    builder.HasMany(t => t.Customers)
                    .WithOne(t => t.Account);

    }

}