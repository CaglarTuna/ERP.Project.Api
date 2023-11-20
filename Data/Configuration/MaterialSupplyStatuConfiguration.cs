using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configuration
{
    public class MaterialSupplyStatuConfiguration : IEntityTypeConfiguration<MaterialSupplyStatu>
    {
        public void Configure(EntityTypeBuilder<MaterialSupplyStatu> builder)
        {
            builder.HasIndex(x => new { x.Id }).IsUnique();
            builder.Property(x => x.Name).HasMaxLength(50).IsRequired(false);
          
        }
    }
}
