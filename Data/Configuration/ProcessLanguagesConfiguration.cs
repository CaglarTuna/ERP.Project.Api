using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class ProcessLanguagesConfiguration : IEntityTypeConfiguration<ProcessLanguage>
    {
        public void Configure(EntityTypeBuilder<ProcessLanguage> builder)
        {
            builder.HasIndex(x => new
            {
                x.LanguageId,
                x.ProcessId
            }).IsUnique();
            builder.HasIndex(x => new { x.ProcessId }).IsUnique();
            builder.Property(x => x.Name).HasMaxLength(1000).IsRequired();
            builder.HasOne(x => x.Process).WithMany(x => x.ProcessLanguage).HasForeignKey(x => x.ProcessId).IsRequired(false);
            builder.HasOne(x => x.Languages).WithMany(x => x.ProcessLanguage).HasForeignKey(x => x.LanguageId).IsRequired(false);

        }
    }
}