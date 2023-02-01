using AccountManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Persistence.EntityConfigs;

public class CustomerConfigs : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.HasKey(k => k.Id);
        builder.Property(p => p.CreatedDate).HasDefaultValue(DateTime.Now);
        builder.Property(p => p.ModifiedDate).HasDefaultValue(DateTime.Now);
        builder.Property(p => p.FirstName).IsRequired();
        builder.Property(p => p.LastName).IsRequired();
        builder.Property(p => p.NationalCode).IsRequired().HasMaxLength(15);


        builder.Property(p => p.AccountId).IsRequired();
        builder.HasOne(p => p.Account)
               .WithMany(p => p.Customers)
               .HasForeignKey(p => p.AccountId);



    }
}

