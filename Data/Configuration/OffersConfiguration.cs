using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class OffersConfiguration : IEntityTypeConfiguration<Offers>
    {
        public void Configure(EntityTypeBuilder<Offers> builder)
        {
            builder.HasIndex(x => new { x.Id }).IsUnique();
            builder.Property(x => x.UnitCost).HasMaxLength(15).IsRequired();
            builder.Property(x => x.TotalCost).HasMaxLength(15).IsRequired();
            builder.Property(x => x.UnitOfferAmount).HasMaxLength(15).IsRequired();
            builder.Property(x => x.LineOfferAmount).HasMaxLength(15).IsRequired();
            builder.Property(x => x.CustomerReply).HasMaxLength(1000).IsRequired();
            builder.Property(x => x.Kdv).HasMaxLength(15).IsRequired();
            builder.HasOne(x => x.Orders).WithMany(x => x.Offers).HasForeignKey(x => x.OrderId).IsRequired(false);
            builder.HasOne(x => x.Products).WithMany(x => x.Offers).HasForeignKey(x => x.ProductId).IsRequired(false);
            builder.HasOne(x => x.Currencies).WithMany(x => x.Offers).HasForeignKey(x => x.CurrencyId).IsRequired(false);
        }
    }
}