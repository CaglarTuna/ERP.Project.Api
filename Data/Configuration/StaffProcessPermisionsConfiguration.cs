using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class StaffProcessPermisionsConfiguration : IEntityTypeConfiguration<StaffProcessPermisions>
    {
        public void Configure(EntityTypeBuilder<StaffProcessPermisions> builder)
        {
            builder.HasIndex(x => new { x.StaffId,x.ProcessId }).IsUnique();
            builder.HasOne(x => x.Staffs).WithMany(x => x.StaffProcessPermisions).HasForeignKey(x => x.StaffId).IsRequired(false);
            builder.HasOne(x => x.Process).WithMany(x => x.StaffProcessPermisions).HasForeignKey(x => x.ProcessId).IsRequired(false);
        }
    }
}