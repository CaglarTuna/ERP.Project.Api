using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class StandsConfiguration : IEntityTypeConfiguration<Stands>
    {
        public void Configure(EntityTypeBuilder<Stands> builder)
        {
            builder.HasIndex(x => new { x.Id }).IsUnique();
            builder.Property(x => x.StandNo).HasMaxLength(10).IsRequired(false);
            builder.Property(x => x.Name).HasMaxLength(1000).IsRequired(false);
        }
    }
}