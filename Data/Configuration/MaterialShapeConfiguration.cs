using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class MaterialShapeConfiguration : IEntityTypeConfiguration<MaterialShape>
    {
        public void Configure(EntityTypeBuilder<MaterialShape> builder)
        {
            builder.HasIndex(x => new { x.Id }).IsUnique(false);
        }
    }
}