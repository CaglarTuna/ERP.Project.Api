using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class OrdersConfiguration : IEntityTypeConfiguration<Orders>
    {
        public void Configure(EntityTypeBuilder<Orders> builder)
        {
            builder.HasIndex(x => new { x.Id }).IsUnique();
            builder.Property(x => x.OrderNote).HasMaxLength(1500).IsRequired(false);
            builder.Property(x => x.OrderNo).HasMaxLength(15).IsRequired(false);
            builder.Property(x => x.OrderFrom).HasMaxLength(50).IsRequired(false);
            builder.Property(x => x.RejectNote).HasMaxLength(1000).IsRequired(false);
            builder.Property(x => x.OrderCustomerNo).HasMaxLength(15).IsRequired(false);
            builder.HasOne(x => x.Stores).WithMany(x => x.Orders).HasForeignKey(x => x.StoreId).IsRequired(false);
            builder.HasOne(x => x.Companies).WithMany(x => x.Orders).HasForeignKey(x => x.CompanyId).IsRequired(false);
            builder.HasOne(x => x.OrderChannel).WithMany(x => x.Orders).HasForeignKey(x => x.OrderChannelId).IsRequired(false);
            builder.HasOne(x => x.Statuss).WithMany(x => x.Orders).HasForeignKey(x => x.OrderStatuId).IsRequired(false);
            builder.HasOne(x => x.Staff).WithMany(x => x.Orders).HasForeignKey(x => x.DellveryStaffId).IsRequired(false);
           
        }
    }
}