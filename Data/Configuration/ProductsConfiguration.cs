using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class ProductsConfiguration : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.HasIndex(x => new { x.Id }).IsUnique();
            builder.Property(x => x.Name).HasMaxLength(1000).IsRequired(false);
            builder.Property(x => x.ProductDescription).HasMaxLength(1500).IsRequired(false);
            builder.Property(x => x.TechnicalImage).HasMaxLength(1000).IsRequired(false);
            builder.Property(x => x.ProductCost).HasMaxLength(15).IsRequired(false);
            builder.Property(x => x.ProductCertificate).HasMaxLength(1000).IsRequired(false);
            builder.Property(x => x.InvoiceNo).HasMaxLength(15).IsRequired(false);
            builder.Property(x => x.BarcodeNo).HasMaxLength(15).IsRequired(false);
            builder.Property(x => x.ProductionSerialNumber).HasMaxLength(15).IsRequired(false);
            builder.HasOne(x => x.Categories).WithMany(x => x.Products).HasForeignKey(x => x.CategoryId).IsRequired(false);
        }
    }
}