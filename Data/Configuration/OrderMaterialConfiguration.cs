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
    public class OrderMaterialConfiguration : IEntityTypeConfiguration<OrderMaterial>
    {
        public void Configure(EntityTypeBuilder<OrderMaterial> builder)
        {
            builder.HasIndex(x => new { x.OrderId, x.MaterialId }).IsUnique(false);
            builder.HasOne(x => x.Orders).WithMany(x => x.OrderMaterials).HasForeignKey(x => x.OrderId).IsRequired(false);
            builder.HasOne(x => x.Materials).WithMany(x => x.OrderMaterials).HasForeignKey(x => x.MaterialId).IsRequired(false);
        }
    }
}
