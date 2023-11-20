using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class StaffProcessConfiguration : IEntityTypeConfiguration<StaffProcess>
    {
        public void Configure(EntityTypeBuilder<StaffProcess> builder)
        {
            builder.HasIndex(x => x.Id).IsUnique();
            builder.Property(x => x.Minute).IsRequired(false);
            builder.Property(x => x.Second).IsRequired(false);
            builder.Property(x => x.Hour).IsRequired(false);
            builder.HasOne(x => x.Staffs).WithMany(x => x.StaffProcess).HasForeignKey(x => x.StaffId).IsRequired(false);
            builder.HasOne(x => x.Products).WithMany(x => x.StaffProcesses).HasForeignKey(x => x.ProductId).IsRequired(false);
            builder.HasOne(x => x.Process).WithMany(x => x.StaffProcess).HasForeignKey(x => x.ProcessId).IsRequired(false);
            builder.HasOne(x => x.Orders).WithMany(x => x.StaffProcesses).HasForeignKey(x => x.OrderProductId).IsRequired(false);
        }
    }
}