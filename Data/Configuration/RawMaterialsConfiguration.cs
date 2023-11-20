using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class RawMaterialsConfiguration : IEntityTypeConfiguration<RawMaterials>
    {
        public void Configure(EntityTypeBuilder<RawMaterials> builder)
        {
            builder.HasIndex(x => new { x.Id }).IsUnique();
            builder.Property(x => x.Code).HasMaxLength(10).IsRequired(false);
            builder.Property(x => x.Name).HasMaxLength(500).IsRequired(false);
            builder.Property(x => x.Density).HasMaxLength(50).IsRequired(false);
        }
    }
}