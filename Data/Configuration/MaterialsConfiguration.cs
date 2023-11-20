using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class MaterialsConfiguration : IEntityTypeConfiguration<Materials>
    {
        public void Configure(EntityTypeBuilder<Materials> builder)
        {
            builder.HasIndex(x => new { x.Id }).IsUnique();
            builder.Property(x => x.Code).HasMaxLength(50).IsRequired(false);
            builder.Property(x => x.CostPrice).HasMaxLength(15).IsRequired(false);
            builder.Property(x => x.StockNo).HasMaxLength(50).IsRequired(false);
            builder.Property(x => x.Name).HasMaxLength(200).IsRequired(false);
            builder.Property(x => x.BarcodeNo).HasMaxLength(15).IsRequired(false);
            builder.Property(x => x.Meter).IsRequired(false);
            builder.Property(x => x.MaterialCertificate).HasMaxLength(250).IsRequired(false);
            builder.HasOne(x => x.Currencies).WithMany(x => x.Materials).HasForeignKey(x => x.CurrencyId).IsRequired(false);
            builder.HasOne(x => x.MaterialShapes).WithMany(x => x.Materials).HasForeignKey(x => x.ShapeId).IsRequired(false);
            builder.HasOne(x => x.HeightMeasure).WithMany(x => x.Materials).HasForeignKey(x => x.HeightMeasureId).IsRequired(false);
            
        }
    }
}
