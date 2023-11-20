using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class MaterialExpertDeliverysConfiguration : IEntityTypeConfiguration<MaterialExpertDeliverys>
    {
        public void Configure(EntityTypeBuilder<MaterialExpertDeliverys> builder)
        {
            builder.HasIndex(x => new { x.Id }).IsUnique();
            builder.Property(x => x.DeliveryNote).HasMaxLength(1500).IsRequired(false);
            builder.HasOne(x => x.Materials).WithMany(x => x.MaterialExpertDeliverys).HasForeignKey(x => x.MaterialId).IsRequired(false);
            builder.HasOne(x => x.Staffs).WithMany(x => x.MaterialExpertDeliverys).HasForeignKey(x => x.StaffId).IsRequired(false);
            builder.HasOne(x => x.Orders).WithMany(x => x.MaterialExpertDeliverys).HasForeignKey(x => x.OrderId).IsRequired(false);
        }
    }
}