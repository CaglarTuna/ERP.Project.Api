using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class HeightMeasureConfiguration : IEntityTypeConfiguration<HeightMeasure>
    {
        public void Configure(EntityTypeBuilder<HeightMeasure> builder)
        {
            builder.HasIndex(x => new { x.Id }).IsUnique();
        }
    }
}
