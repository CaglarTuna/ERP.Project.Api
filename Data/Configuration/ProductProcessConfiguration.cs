using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class ProductProcessConfiguration : IEntityTypeConfiguration<ProductProcess>
    {
        public void Configure(EntityTypeBuilder<ProductProcess> builder)
        {
            builder.HasIndex(x => new { x.ProductId,x.ProcessId }).IsUnique();
            builder.HasOne(x => x.Products).WithMany(x => x.ProductProcess).HasForeignKey(x => x.ProductId).IsRequired(false);
            builder.HasOne(x => x.Process).WithMany(x => x.ProductProcess).HasForeignKey(x => x.ProcessId).IsRequired(false);
        }
    }
}