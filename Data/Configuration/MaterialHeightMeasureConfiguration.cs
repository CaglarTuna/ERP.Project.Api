using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class MaterialHeightMeasureConfiguration : IEntityTypeConfiguration<MaterialHeightMeasure>
    {
        public void Configure(EntityTypeBuilder<MaterialHeightMeasure> builder)
        {
            builder.HasIndex(x => new { x.HeightMeasureId , x.MaterialId }).IsUnique();
            builder.HasOne(x => x.HeightMeasures).WithMany(x => x.MaterialHeightMeasures).HasForeignKey(x => x.HeightMeasureId).IsRequired(false);
            builder.HasOne(x => x.Materials).WithMany(x => x.MaterialHeightMeasures).HasForeignKey(x => x.MaterialId).IsRequired(false);
        }
    }
}