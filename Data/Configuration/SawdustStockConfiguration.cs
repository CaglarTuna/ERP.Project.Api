using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class SawdustStockConfiguration : IEntityTypeConfiguration<SawdustStock>
    {
        public void Configure(EntityTypeBuilder<SawdustStock> builder)
        {
            builder.HasIndex(x => new { x.Id }).IsUnique();
            builder.Property(x => x.InvoiceNo).HasMaxLength(15).IsRequired(false);
            builder.Property(x => x.SawdustStockAddress).HasMaxLength(200).IsRequired(false);
            builder.Property(x => x.CurrencyId).IsRequired(false);
            builder.Property(x => x.Price).IsRequired(false);
            builder.Property(x => x.ReturnReasonId).IsRequired(false);
            builder.HasOne(x => x.Materials).WithMany(x => x.SawdustStocks).HasForeignKey(x => x.MaterialId).IsRequired(false);
            builder.HasOne(x => x.Companies).WithMany(x => x.SawdustStocks).HasForeignKey(x => x.CompanyId).IsRequired(false);
            builder.HasOne(x => x.Stores).WithMany(x => x.SawdustStocks).HasForeignKey(x => x.StoreId).IsRequired(false);
            builder.HasOne(x => x.Currencies).WithMany(x => x.SawdustStock).HasForeignKey(x => x.CurrencyId).IsRequired(false);
            builder.HasOne(x => x.Orders).WithMany(x => x.SawdustStock).HasForeignKey(x => x.OrderNo).IsRequired(false);
        }
    }
}