using LiCakes.Domain.Aggregates.PurchaseAgregate;
using LiCakes.Infra.Data.Converters;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LiCakes.Infra.Data.Configurations
{
  public class PurchaseConfiguration : IEntityTypeConfiguration<Purchase>
  {
    public void Configure(EntityTypeBuilder<Purchase> builder)
    {
      builder.HasKey(p => p.Id);
      builder.Property(x => x.Supplier)
        .IsRequired()
        .HasMaxLength(150);

      builder.Property(x => x.TotalValue)
        .HasColumnType("decimal(10,2)");

      builder.Property(x => x.PurchaseDate)
        .HasConversion<DateOnlyConverter, DateOnlyComparer>()
        .IsRequired();

    }
  }
}
