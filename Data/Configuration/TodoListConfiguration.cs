using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class TodoListConfiguration : IEntityTypeConfiguration<TodoList>
    {
        public void Configure(EntityTypeBuilder<TodoList> builder)
        {
            builder.HasIndex(x => new { x.Id }).IsUnique();
            builder.Property(x => x.Description).HasMaxLength(1000).IsRequired(false);
            builder.HasOne(x => x.Orders).WithMany(x => x.TodoList).HasForeignKey(x => x.InterestId).IsRequired(false);
        }
    }
}