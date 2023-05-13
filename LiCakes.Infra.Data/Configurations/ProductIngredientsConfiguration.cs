using LiCakes.Domain.Aggregates.ProductAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiCakes.Infra.Data.Configurations
{
  public class ProductIngredientsConfiguration : IEntityTypeConfiguration<ProductIngredient>
  {
    public void Configure(EntityTypeBuilder<ProductIngredient> builder)
    {
      builder.ToTable("ProductIngredients");

      builder.HasKey(x => x.Id);

      builder.Property(x => x.ProductId)
        .IsRequired();

      builder.Property(x => x.MaterialId)
        .IsRequired();

      builder.Property(x => x.Quantity)
        .IsRequired();
    }
  }
}
