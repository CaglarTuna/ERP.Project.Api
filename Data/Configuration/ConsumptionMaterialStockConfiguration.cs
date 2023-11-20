using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class ConsumptionMaterialStockConfiguration : IEntityTypeConfiguration<ConsumptionMaterialStock>
    {
        public void Configure(EntityTypeBuilder<ConsumptionMaterialStock> builder)
        {
            builder.HasIndex(x => new { x.Id }).IsUnique();
            builder.HasOne(x => x.ConsumptionMaterials).WithMany(x => x.ConsumptionMaterialStock).HasForeignKey(x => x.ConsumptionMaterialId).IsRequired(false);
            builder.HasOne(x => x.Companies).WithMany(x => x.ConsumptionMaterialStock).HasForeignKey(x => x.CompanyId).IsRequired(false);
            builder.HasOne(x => x.Staffs).WithMany(x => x.ConsumptionMaterialStock).HasForeignKey(x => x.StaffId).IsRequired(false);
            builder.HasOne(x => x.Stores).WithMany(x => x.ConsumptionMaterialStock).HasForeignKey(x => x.StoreId).IsRequired(false);
            builder.HasOne(x => x.Stands).WithMany(x => x.consumptionMaterials).HasForeignKey(x => x.StandId).IsRequired(false);
            builder.HasOne(x => x.Orders).WithMany(x => x.ConsumptionMaterialStocks).HasForeignKey(x => x.OrderId).IsRequired(false);
            builder.Property(x => x.ConsumptionMaterialAddress).HasMaxLength(500).IsRequired(false);
            builder.Property(x => x.InvoiceNo).HasMaxLength(15).IsRequired(false);
            builder.Property(x => x.DeliveryNote).HasColumnType("nvarchar(max)").IsRequired(false);
        }
    }
}