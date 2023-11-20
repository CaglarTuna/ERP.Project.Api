using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configuration
{
    public class TodoMemberConfiguration : IEntityTypeConfiguration<TodoMember>
    {
        public void Configure(EntityTypeBuilder<TodoMember> builder)
        {
            builder.HasIndex(x => x.Id).IsUnique();
            builder.HasOne(x => x.Staffs).WithMany(x => x.TodoMembers).HasForeignKey(x => x.StaffId).IsRequired(false);
            builder.HasOne(x => x.TodoList).WithMany(x => x.TodoMembers).HasForeignKey(x => x.TodoId).IsRequired(false);
        }
    }
}
