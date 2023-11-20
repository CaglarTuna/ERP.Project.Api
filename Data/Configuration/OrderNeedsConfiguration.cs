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
    public class OrderNeedsConfiguration : IEntityTypeConfiguration<OrderNeeds>
    {
        public void Configure(EntityTypeBuilder<OrderNeeds> builder)
        {
            builder.HasIndex(x => new { x.Id }).IsUnique();
            builder.HasOne(x => x.Materials).WithMany(x => x.OrderNeeds).HasForeignKey(x => x.MaterialId).IsRequired(false);
            builder.HasOne(x => x.Orders).WithMany(x => x.OrderNeeds).HasForeignKey(x => x.OrderId).IsRequired(false);
            builder.HasOne(x => x.Products).WithMany(x => x.OrderNeeds).HasForeignKey(x => x.ProductId).IsRequired(false);
        }
    }
}
