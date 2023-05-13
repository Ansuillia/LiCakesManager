using LiCakes.Domain.Aggregates.PurchaseAgregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LiCakes.Infra.Data.Configurations
{
  public class PurchaseMaterialConfiguration : IEntityTypeConfiguration<PurchaseMaterial>
  {
    public void Configure(EntityTypeBuilder<PurchaseMaterial> builder)
    {
      builder.HasKey(x => x.Id);
      builder.Property(x => x.PurchaseId)
        .IsRequired();
      builder.Property(x => x.MaterialId)
        .IsRequired();
      builder.Property(x => x.Price)
        .HasColumnType("decimal(10,2)")
        .IsRequired();
    }
  }
}
