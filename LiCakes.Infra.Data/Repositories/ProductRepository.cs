using LiCakes.Domain.Aggregates.ProductAggregate;
using LiCakes.Domain.Agregates;
using LiCakes.Infra.Data.Context;
using LiCakes.Infra.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LiCakes.Infra.Data.Repositories
{
    public class ProductRepository : Repository<Product, long>, IProductRepository
  {
    public ProductRepository(LiCakesDbContext context) : base(context)
    {
    }

    public Task<Category> FindOrCreateCategory(string categoryName, string? categoryDescription)
    {
      var existCategory = _context.Set<Category>().FirstOrDefault(x => x.Name.ToUpper() == categoryName.ToUpper());
      if(existCategory is not null) return Task.FromResult(existCategory);

      var newCategory = _context.Set<Category>().Add(new Category(categoryName, categoryDescription));

      return Task.FromResult(newCategory.Entity);
    }
  }
}
