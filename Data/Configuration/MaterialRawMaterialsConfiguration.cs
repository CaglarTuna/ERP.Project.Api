using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class MaterialRawMaterialsConfiguration : IEntityTypeConfiguration<MaterialRawMaterials>
    {
        public void Configure(EntityTypeBuilder<MaterialRawMaterials> builder)
        {
            builder.HasIndex(x => new { x.MaterialId,x.RawMaterialId }).IsUnique();
            builder.HasOne(x => x.Materials).WithMany(x => x.MaterialRawMaterials).HasForeignKey(x => x.MaterialId).IsRequired(false);
            builder.HasOne(x => x.RawMaterials).WithMany(x => x.MaterialRawMaterials).HasForeignKey(x => x.RawMaterialId).IsRequired(false);
        }
    }
}