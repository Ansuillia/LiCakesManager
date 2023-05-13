using LiCakes.Domain.Aggregates.ProductAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LiCakes.Infra.Data.Configurations
{
  public class ProductConfiguration : IEntityTypeConfiguration<Product>
  {
    public void Configure(EntityTypeBuilder<Product> builder)
    {
      builder.HasKey(x => x.Id);

      builder.Property(x => x.Name)
        .IsRequired()
        .HasMaxLength(120);

      builder.Property(x => x.Description)
        .HasMaxLength(300);

      builder.Property(x => x.Price)
        .HasDefaultValue(0)
        .HasColumnType("decimal(10,2)");

    }
  }
}
