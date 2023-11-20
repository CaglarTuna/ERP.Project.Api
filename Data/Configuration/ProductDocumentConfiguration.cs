using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class ProductDocumentConfiguration : IEntityTypeConfiguration<ProductDocument>
    {
        public void Configure(EntityTypeBuilder<ProductDocument> builder)
        {
            builder.HasIndex(x => new
            {
                x.DocumentId,
                x.ProductId
            }).IsUnique();
            builder.HasOne(x => x.Products).WithMany(x => x.ProductDocuments).HasForeignKey(x => x.ProductId).IsRequired(false);
            builder.HasOne(x => x.Document).WithMany(x => x.ProductDocuments).HasForeignKey(x => x.DocumentId).IsRequired(false);
        }
    }
}
