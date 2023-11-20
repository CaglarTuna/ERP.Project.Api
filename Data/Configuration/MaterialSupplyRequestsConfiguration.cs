using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class MaterialSupplyRequestsConfiguration : IEntityTypeConfiguration<MaterialSupplyRequests>
    {
        public void Configure(EntityTypeBuilder<MaterialSupplyRequests> builder)
        {
            builder.HasIndex(x => new { x.Id }).IsUnique();
            builder.HasOne(x => x.Materials).WithMany(x => x.MaterialSupplyRequests).HasForeignKey(x => x.MaterialId).IsRequired(false);
            builder.HasOne(x => x.Orders).WithMany(x => x.MaterialSupplyRequests).HasForeignKey(x => x.OrderId).IsRequired(false);
            builder.HasOne(x => x.Companies).WithMany(x => x.MaterialSupplyRequests).HasForeignKey(x => x.CompanyId).IsRequired(false);
            builder.HasOne(x => x.MaterialSupply).WithMany(x => x.MaterialSupplyRequests).HasForeignKey(x => x.SuplyStatuId).IsRequired(false);
            
        }
    }
}