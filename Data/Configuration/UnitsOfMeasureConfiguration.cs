using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class UnitsOfMeasureConfiguration : IEntityTypeConfiguration<UnitsOfMeasure>
    {
        public void Configure(EntityTypeBuilder<UnitsOfMeasure> builder)
        {
            builder.HasIndex(x => new { x.Id }).IsUnique();
            builder.Property(x => x.Name).HasMaxLength(250).IsRequired(false);
        }
    }
}