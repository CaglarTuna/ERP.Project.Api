using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class RejectionConfiguration : IEntityTypeConfiguration<Rejection>
    {
        public void Configure(EntityTypeBuilder<Rejection> builder)
        {
            builder.HasIndex(x => new { x.Id }).IsUnique(false);
        }
    }
}
