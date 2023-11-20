using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class OrderProductsConfiguration : IEntityTypeConfiguration<OrderProducts>
    {
        public void Configure(EntityTypeBuilder<OrderProducts> builder)
        {
            builder.HasIndex(x => new { x.OrderId, x.ProductId }).IsUnique(false);
            builder.HasOne(x => x.Orders).WithMany(x => x.OrderProducts).HasForeignKey(x => x.OrderId).IsRequired(false);
            builder.HasOne(x => x.Products).WithMany(x => x.OrderProducts).HasForeignKey(x => x.ProductId).IsRequired(false);
            builder.HasOne(x => x.Statuss).WithMany(x => x.OrderProducts).HasForeignKey(x => x.StatusId).IsRequired(false);
        }
    }
}