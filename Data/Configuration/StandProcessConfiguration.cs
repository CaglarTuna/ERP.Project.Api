using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class StandProcessConfiguration : IEntityTypeConfiguration<StandProcess>
    {
        public void Configure(EntityTypeBuilder<StandProcess> builder)
        {
            builder.HasIndex(x => new { x.StandId,x.ProcessId }).IsUnique();
            builder.HasOne(x => x.Stands).WithMany(x => x.StandProcess).HasForeignKey(x => x.StandId).IsRequired(false);
            builder.HasOne(x => x.Process).WithMany(x => x.StandProcess).HasForeignKey(x => x.ProcessId).IsRequired(false);
        }
    }
}