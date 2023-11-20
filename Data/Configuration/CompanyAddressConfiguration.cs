using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class CompanyAddressConfiguration : IEntityTypeConfiguration<CompanyAddress>
    {
        public void Configure(EntityTypeBuilder<CompanyAddress> builder)
        {
            builder.HasIndex(x => new { x.Id }).IsUnique();
            builder.HasOne(x => x.Companies).WithMany(x => x.CompanyAddress).HasForeignKey(x => x.CompanyId).IsRequired(false);
            //builder.HasOne(x => x.Countries).WithMany(x => x.CompanyAddress).HasForeignKey(x => x.CountryId);
            //builder.HasOne(x => x.Cities).WithMany(x => x.CompanyAddress).HasForeignKey(x => x.CityId);
            builder.Property(x => x.PostCode).HasMaxLength(50).IsRequired(false);
            builder.Property(x => x.AddressTitle).HasMaxLength(50).IsRequired(false);
            builder.Property(x => x.Address).HasMaxLength(1000).IsRequired(false);
        }
    }
}