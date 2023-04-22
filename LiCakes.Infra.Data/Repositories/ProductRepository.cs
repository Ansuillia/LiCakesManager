using LiCakes.Domain.Entities;
using LiCakes.Domain.Interfaces.Repositories;
using LiCakes.Infra.Data.Context;
using LiCakes.Infra.Data.Interfaces;

namespace LiCakes.Infra.Data.Repositories
{
  public class ProductRepository : Repository<Product>, IProductRepository
  {
    public ProductRepository(LiCakesDbContext context) : base(context)
    {
    }
  }
}
