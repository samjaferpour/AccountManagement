using AccountManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccountManagement.Persistence.EntityConfigs
{
    public class LetterConfigs : IEntityTypeConfiguration<Letter>
    {
        public void Configure(EntityTypeBuilder<Letter> builder)
        {
            builder.HasKey(k => k.Id);
            builder.Property(p => p.CreatedDate).HasDefaultValue(DateTime.Now);
            builder.Property(p => p.ModifiedDate).HasDefaultValue(DateTime.Now);
            builder.Property(p => p.Date).IsRequired().HasDefaultValue(DateTime.Now.ToString("d"));
            builder.Property(p => p.Number).IsRequired().HasMaxLength(20);
            
            builder.Property(p => p.Title).IsRequired();
            builder.Property(p => p.Deadline).IsRequired();
            builder.Property(p => p.Content).IsRequired();
            builder.Property(p => p.ReceiptDate).IsRequired(false);


            builder.HasOne(t => t.LetterType)
                   .WithMany(t => t.Letters)
                   .HasForeignKey(t => t.LetterTypeId);

         

        }
    }
}
