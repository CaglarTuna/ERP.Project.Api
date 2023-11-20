using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class ProductMaterialsConfiguration : IEntityTypeConfiguration<ProductMaterials>
    {
        public void Configure(EntityTypeBuilder<ProductMaterials> builder)
        {
            builder.HasIndex(x => new { x.ProductId, x.MaterialId }).IsUnique();
            builder.HasOne(x => x.Materials).WithMany(x => x.ProductMaterials).HasForeignKey(x => x.MaterialId).IsRequired(false);
            builder.HasOne(x => x.Products).WithMany(x => x.ProductMaterials).HasForeignKey(x => x.ProductId).IsRequired(false);
            builder.HasOne(x => x.UnitsOfMeasure).WithMany(x => x.ProductMaterials).HasForeignKey(x => x.UnitMeasureId).IsRequired(false);
            builder.HasOne(x => x.HeightMeasures).WithMany(x => x.ProductMaterials).HasForeignKey(x => x.HeightMeasureId).IsRequired(false);
            builder.HasOne(x => x.Statuss).WithMany(x => x.ProductMaterials).HasForeignKey(x => x.StatusId).IsRequired(false);
        }
    }
}