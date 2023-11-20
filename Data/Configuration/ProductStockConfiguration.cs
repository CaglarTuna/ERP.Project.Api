using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class ProductStockConfiguration : IEntityTypeConfiguration<ProductStock>
    {
        public void Configure(EntityTypeBuilder<ProductStock> builder)
        {
            builder.HasIndex(x => new { x.Id }).IsUnique();
            builder.Property(x => x.UniqueNo).HasMaxLength(15).IsRequired(false);
            builder.Property(x => x.ProductAddress).HasMaxLength(250).IsRequired(false);
            builder.HasOne(x => x.Products).WithMany(x => x.ProductStock).HasForeignKey(x => x.ProductId).IsRequired(false);
            builder.HasOne(x => x.Stores).WithMany(x => x.ProductStock).HasForeignKey(x => x.StoreId).IsRequired(false);
        }
    }
}