using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class ConsumptionMaterialSuppliersConfiguration : IEntityTypeConfiguration<ConsumptionMaterialSuppliers>
    {
        public void Configure(EntityTypeBuilder<ConsumptionMaterialSuppliers> builder)
        {
            builder.HasIndex(x => new { x.Id }).IsUnique();
            builder.HasOne(x => x.ConsumptionMaterials).WithMany(x => x.ConsumptionMaterialSuppliers).HasForeignKey(x => x.ConsumptionMaterialId).IsRequired(false);
            builder.HasOne(x => x.Companies).WithMany(x => x.ConsumptionMaterialSuppliers).HasForeignKey(x => x.CompanyId).IsRequired(false);
        }
    }
}