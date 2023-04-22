using LiCakes.Domain.Interfaces.Repositories;

namespace LiCakes.Infra.Data
{
  public interface IUnitOfWork : IDisposable
  {
    int Commit();
    Task<int> CommitAsync();

    IProductRepository ProductRepository { get; }
  }
}
