using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class MaterialSuppliersConfiguration : IEntityTypeConfiguration<MaterialSuppliers>
    {
        public void Configure(EntityTypeBuilder<MaterialSuppliers> builder)
        {
            builder.HasIndex(x => new { x.Id }).IsUnique();
            builder.HasOne(x => x.Materials).WithMany(x => x.MaterialSuppliers).HasForeignKey(x => x.MaterialId).IsRequired(false);
            builder.HasOne(x => x.Companies).WithMany(x => x.MaterialSuppliers).HasForeignKey(x => x.CompanyId).IsRequired(false);
        }
    }
}