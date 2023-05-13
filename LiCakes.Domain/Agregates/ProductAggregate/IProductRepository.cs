using LiCakes.Domain.Agregates;
using LiCakes.Domain.SeedWork;

namespace LiCakes.Domain.Aggregates.ProductAggregate
{
  public interface IProductRepository : IRepository<Product, long>
  {
    Task<Category> FindOrCreateCategoryAsync(string categoryName, string? categoryDescription);
    IAsyncEnumerable<Product> GetAllByCategoryNameAsync(string categoryName);
  }
}
