using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class ConsumptionMaterialsConfiguration : IEntityTypeConfiguration<ConsumptionMaterials>
    {
        public void Configure(EntityTypeBuilder<ConsumptionMaterials> builder)
        {
            builder.HasIndex(x => new { x.Id }).IsUnique();
            builder.Property(x => x.Name).HasMaxLength(200).IsRequired(false);
            builder.Property(x => x.Code).HasMaxLength(200).IsRequired(false);
            builder.HasOne(x => x.Currencies).WithMany(x => x.ConsumptionMaterials).HasForeignKey(x => x.CurrencyId).IsRequired(false);
            builder.HasOne(x => x.Companies).WithMany(x => x.ConsumptionMaterials).HasForeignKey(x => x.CompanyId).IsRequired(false);
            builder.HasOne(x => x.UnitsOfMeasure).WithMany(x => x.ConsumptionMaterials).HasForeignKey(x => x.UnitsOfMeasureId).IsRequired(false);
            //builder.HasOne(x => x.UnitsOfMeasure).WithMany(x => x.ConsumptionMaterials).HasForeignKey(x => x.ConsumptionUnitId).IsRequired(false);
        }
    }
}