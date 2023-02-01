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
    public class TransactionConfigs : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasKey(k => k.Id);
            builder.Property(p => p.CreatedDate).HasDefaultValue(DateTime.Now);
            builder.Property(p => p.ModifiedDate).HasDefaultValue(DateTime.Now);

            builder.Property(p => p.AccountBlockingStatusCode).IsRequired(false);
            builder.Property(p => p.AccountBlockingStatusDescription).IsRequired(false);
            builder.Property(p => p.AccountBlockingStatusDescription).HasMaxLength(500);
            builder.Property(p => p.AccountBlockingTraceNumber).IsRequired(false);
            builder.Property(p => p.AccountBlockingTraceNumber).HasMaxLength(200);
            builder.Property(p => p.AccountBlockingDate).IsRequired(false);
            builder.Property(p => p.AccountBlockingDate).HasMaxLength(25);

            builder.Property(p => p.WithdrawBlockingStatusCode).IsRequired(false);
            builder.Property(p => p.WithdrawBlockingStatusDescription).IsRequired(false);
            builder.Property(p => p.WithdrawBlockingStatusDescription).HasMaxLength(500);
            builder.Property(p => p.WithdrawBlockingTraceNumber).IsRequired(false);
            builder.Property(p => p.WithdrawBlockingTraceNumber).HasMaxLength(200);
            builder.Property(p => p.WithdrawBlockingDate).IsRequired(false);
            builder.Property(p => p.WithdrawBlockingDate).HasMaxLength(25);


        }

        
    }
}
