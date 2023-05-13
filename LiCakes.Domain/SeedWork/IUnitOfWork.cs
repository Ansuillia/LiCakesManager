using LiCakes.Domain.Aggregates.ProductAggregate;

namespace LiCakes.Domain.SeedWork
{
  public interface IUnitOfWork : IDisposable
  {
    int Commit();
    Task<int> CommitAsync();

    IProductRepository ProductRepository { get; }
  }
}
