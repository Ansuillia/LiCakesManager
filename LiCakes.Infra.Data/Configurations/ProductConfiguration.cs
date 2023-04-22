using LiCakes.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

      builder.HasOne(x => x.Category)
        .WithMany(x => x.Products)
        .IsRequired();
    }
  }
}
