using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class CompaniesConfiguration : IEntityTypeConfiguration<Companies>
    {
        public void Configure(EntityTypeBuilder<Companies> builder)
        {
            builder.HasIndex(x => new { x.Id }).IsUnique();
            builder.Property(x => x.TaxNumber).HasMaxLength(15).IsRequired(false);
            builder.Property(x => x.TaxOffice).HasMaxLength(200).IsRequired(false);
            builder.Property(x => x.Department).HasMaxLength(200).IsRequired(false);
            builder.Property(x => x.ContactPerson).HasMaxLength(200).IsRequired(false);
            builder.Property(x => x.Email).HasMaxLength(100).IsRequired(false);
            builder.Property(x => x.Phone).HasMaxLength(15).IsRequired(false);
            builder.Property(x => x.Telephone).HasMaxLength(15).IsRequired(false);
            builder.Property(x => x.Prefix).HasMaxLength(3).IsRequired(false);
        }
    }
}