using Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class CityLanguageConfiguration
    {
        public void Configure(EntityTypeBuilder<CityLanguage> builder)
        {
            builder.HasIndex(x => new
            {
                x.LanguageId,
                x.CityId
            }).IsUnique();
        }
    }
}
