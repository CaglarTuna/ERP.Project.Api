using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class StaffsConfiguration : IEntityTypeConfiguration<Staffs>
    {
        public void Configure(EntityTypeBuilder<Staffs> builder)
        {
            builder.HasIndex(x => new { x.Id }).IsUnique();
            builder.Property(x => x.Name).HasMaxLength(100).IsRequired(false);
            builder.Property(x => x.Surname).HasMaxLength(100).IsRequired(false);
            builder.Property(x => x.Email).HasMaxLength(100).IsRequired(false);
            builder.Property(x => x.Telephone).HasMaxLength(15).IsRequired(false);
            builder.Property(x => x.Department).HasMaxLength(250).IsRequired(false);
            builder.Property(x => x.Address).HasMaxLength(int.MaxValue).IsRequired(false);
            builder.Property(x => x.StaffNo).HasMaxLength(100).IsRequired(false);
        }
    }
}