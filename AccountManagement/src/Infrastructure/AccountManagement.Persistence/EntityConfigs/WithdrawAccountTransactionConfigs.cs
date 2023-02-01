using AccountManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccountManagement.Persistence.EntityConfigs
{
    public class WithdrawAccountTransactionConfigs : IEntityTypeConfiguration<WithdrawAccountTransaction>
    {
        public void Configure(EntityTypeBuilder<WithdrawAccountTransaction> builder)
        {
            builder.HasKey(k => k.Id);
            builder.Property(p => p.CreatedDate).HasDefaultValue(DateTime.Now);
            builder.Property(p => p.ModifiedDate).HasDefaultValue(DateTime.Now);

            builder.Property(p => p.Status).IsRequired();
            builder.Property(p => p.Description).IsRequired(false);
            builder.Property(p => p.Description).HasMaxLength(500);
            builder.Property(p => p.TraceNumber).IsRequired(false);
            builder.Property(p => p.TraceNumber).HasMaxLength(200);
            builder.Property(p => p.Date).IsRequired(false);
            builder.Property(p => p.Date).HasMaxLength(25);

            builder.HasOne(t => t.Account)
                   .WithOne(t => t.WithdrawAccountTransaction);

        }
    }
}
