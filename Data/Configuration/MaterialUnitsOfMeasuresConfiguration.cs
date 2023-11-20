using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class MaterialUnitsOfMeasuresConfiguration : IEntityTypeConfiguration<MaterialUnitsOfMeasures>
    {
        public void Configure(EntityTypeBuilder<MaterialUnitsOfMeasures> builder)
        {
            builder.HasIndex(x => new { x.MaterialId, x.UnitsOfMeasureId }).IsUnique();
            builder.HasOne(x => x.Materials).WithMany(x => x.MaterialUnitsOfMeasures).HasForeignKey(x => x.MaterialId).IsRequired(false);
            builder.HasOne(x => x.UnitsOfMeasure).WithMany(x => x.MaterialUnitsOfMeasures).HasForeignKey(x => x.UnitsOfMeasureId).IsRequired(false);
            builder.HasOne(x => x.UnitsOfMeasure).WithMany(x => x.MaterialUnitsOfMeasures).HasForeignKey(x => x.PurchasingUnitId).IsRequired(false);
        }
    }
}