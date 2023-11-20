using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class CurrenciesConfiguration : IEntityTypeConfiguration<Currencies>
    {
        public void Configure(EntityTypeBuilder<Currencies> builder)
        {
            builder.HasIndex(x => new { x.Id }).IsUnique();
            builder.Property(x => x.Name).HasMaxLength(50).IsRequired(false);
        }
    }
}