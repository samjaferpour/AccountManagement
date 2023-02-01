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
    public class LetterTypeConfig : IEntityTypeConfiguration<LetterType>
    {
        public void Configure(EntityTypeBuilder<LetterType> builder)
        {
            builder.HasMany(x => x.Letters)
                .WithOne(x => x.LetterType);
        }

        
    }
}
