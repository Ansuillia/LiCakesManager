using LiCakes.Domain.Aggregates.ProductAggregate;
using LiCakes.Domain.Aggregates.PurchaseAgregate;
using LiCakes.Domain.Agregates;
using LiCakes.Domain.Entities;
using LiCakes.Infra.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LiCakes.Infra.Data.Context
{
    public class LiCakesDbContext : DbContext, IDatabaseContext
  {
    public LiCakesDbContext(DbContextOptions<LiCakesDbContext> options) : base(options)
    {
    }
    public virtual DbSet<Product> Products { get; set; }
    public virtual DbSet<Category> Categories { get; set; }
    public virtual DbSet<Purchase> Purchases { get; set; }
    public virtual DbSet<Material> Materials { get; set; }
    public virtual DbSet<ProductIngredient> ProductMaterials { get; set; }
    public virtual DbSet<PurchaseMaterial> PurchaseMaterials { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.ApplyConfigurationsFromAssembly(typeof(LiCakesDbContext).Assembly);

      base.OnModelCreating(modelBuilder);
    }
  }
}
