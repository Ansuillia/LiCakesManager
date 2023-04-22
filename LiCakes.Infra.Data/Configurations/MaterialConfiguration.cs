using LiCakes.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LiCakes.Infra.Data.Configurations
{
  public class MaterialConfiguration : IEntityTypeConfiguration<Material>
  {
    public void Configure(EntityTypeBuilder<Material> builder)
    {
      builder.HasKey(x => x.Id);
      builder.Property(x => x.Name)
        .IsRequired();
      builder.Property(x => x.Unity)
        .IsRequired()
        .HasConversion<string>();
    }
  }
}
