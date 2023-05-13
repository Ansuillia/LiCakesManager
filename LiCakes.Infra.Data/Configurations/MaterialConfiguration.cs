using LiCakes.Domain.Entities;
using LiCakes.Domain.Enums;
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
        .HasMaxLength(80)
        .IsRequired();
      builder.Property(x => x.Unity)
        .IsRequired()
        .HasMaxLength(2)
        .HasConversion(
          v => v.ToString(),
          v => (EnumUnity)Enum.Parse(typeof(EnumUnity), v)
        );
    }
  }
}
