using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class SpeacialProductDescriptionConfiguration : IEntityTypeConfiguration<SpeacialProductDescription>
    {
        public void Configure(EntityTypeBuilder<SpeacialProductDescription> builder)
        {
            builder.HasIndex(x => new { x.Id }).IsUnique();
            builder.Property(x => x.SpecialProductDescription).HasMaxLength(1500).IsRequired(false);
            builder.Property(x => x.Name).IsRequired(false);
            builder.Property(x => x.Quantitiy).IsRequired(false);
        }
    }
}