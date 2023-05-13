using LiCakes.Domain.Agregates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LiCakes.Infra.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
  {
    public void Configure(EntityTypeBuilder<Category> builder)
    {
      builder.HasKey(x => x.Id);
           
      builder.Property(x => x.Name)
        .IsRequired()
        .HasMaxLength(50);
      
      builder.Property(x => x.Description)
        .HasMaxLength(100);

    }
  }
}
