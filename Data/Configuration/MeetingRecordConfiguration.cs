using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class MeetingRecordConfiguration : IEntityTypeConfiguration<MeetingRecord>
    {
        public void Configure(EntityTypeBuilder<MeetingRecord> builder)
        {
            builder.HasIndex(x => new { x.Id }).IsUnique();
            builder.HasOne(x => x.Orders).WithMany(x => x.MeetingRecords).HasForeignKey(x => x.OrderId).IsRequired(false);
        }
    }
}