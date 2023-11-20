using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class MaterialCertificatesConfiguration : IEntityTypeConfiguration<MaterialCertificates>
    {
        public void Configure(EntityTypeBuilder<MaterialCertificates> builder)
        {
            builder.HasIndex(x => new { x.Id }).IsUnique();
            builder.Property(x => x.Certificate).HasMaxLength(1000).IsRequired(false);
            builder.HasOne(x => x.Materials).WithMany(x => x.MaterialCertificates).HasForeignKey(x => x.MaterialId).IsRequired(false);
            builder.HasOne(x => x.Companies).WithMany(x => x.MaterialCertificates).HasForeignKey(x => x.CompanyId).IsRequired(false);
        }
    }
}