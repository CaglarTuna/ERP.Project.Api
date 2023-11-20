using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class StaffRolesConfiguration : IEntityTypeConfiguration<StaffRoles>
    {
        public void Configure(EntityTypeBuilder<StaffRoles> builder)
        {
            builder.HasIndex(x => new { x.StaffId,x.RoleId }).IsUnique();
            builder.HasOne(x => x.Staffs).WithMany(x => x.StaffRoles).HasForeignKey(x => x.StaffId).IsRequired(false);
            builder.HasOne(x => x.Roles).WithMany(x => x.StaffRoles).HasForeignKey(x => x.RoleId).IsRequired(false);
        }
    }
}