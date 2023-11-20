using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class ProcessConfiguration : IEntityTypeConfiguration<Process>
    {
        public void Configure(EntityTypeBuilder<Process> builder)
        {
            builder.HasIndex(x => new { x.Id }).IsUnique();
            builder.Property(x => x.Cost).HasMaxLength(20).IsRequired(false);
            builder.Property(x => x.ProcessNo).HasMaxLength(10).IsRequired(false);
            builder.HasOne(x => x.Currencies).WithMany(x => x.Processes).HasForeignKey(x => x.CurrencyId).IsRequired(false);
        }
    }
}