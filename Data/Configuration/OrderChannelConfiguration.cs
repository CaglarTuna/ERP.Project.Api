using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class OrderChannelConfiguration : IEntityTypeConfiguration<OrderChannel>
    {
        public void Configure(EntityTypeBuilder<OrderChannel> builder)
        {
            builder.HasIndex(x => new { x.Id }).IsUnique();
            builder.Property(x => x.Name).HasMaxLength(40).IsRequired(false);
        }
    }
}