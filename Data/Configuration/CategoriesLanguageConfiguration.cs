using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class CategoriesLanguageConfiguration : IEntityTypeConfiguration<CategoriesLanguage>
    {
        public void Configure(EntityTypeBuilder<CategoriesLanguage> builder)
        {
            builder.HasIndex(x => new
            {
                x.LanguageId,
                x.CategoriesId
            }).IsUnique();
            builder.Property(x => x.Name).HasMaxLength(250).IsRequired(false);
            builder.HasOne(x => x.Categories).WithMany(x => x.CategoriesLanguage).HasForeignKey(x => x.CategoriesId).IsRequired(false);
            builder.HasOne(x => x.Languages).WithMany(x => x.CategoriesLanguage).HasForeignKey(x => x.LanguageId).IsRequired(false);
        }
    }
}