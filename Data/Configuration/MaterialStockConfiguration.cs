using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class MaterialStockConfiguration : IEntityTypeConfiguration<MaterialStock>
    {
        public void Configure(EntityTypeBuilder<MaterialStock> builder)
        {
            builder.HasIndex(x => new { x.Id }).IsUnique();
            builder.Property(x => x.MaterialAdress).HasMaxLength(250).IsRequired(false);
            builder.Property(x => x.InvoiceNo).HasMaxLength(15).IsRequired(false);
            builder.HasOne(x => x.Materials).WithMany(x => x.MaterialStock).HasForeignKey(x => x.MaterialId).IsRequired(false);
            builder.HasOne(x => x.Companies).WithMany(x => x.MaterialStocks).HasForeignKey(x => x.CompanyId).IsRequired(false);
            builder.HasOne(x => x.Stores).WithMany(x => x.MaterialStocks).HasForeignKey(x => x.StoreId).IsRequired(false);
        }
    }
}