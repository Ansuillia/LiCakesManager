using LiCakes.Domain.Aggregates.ProductAggregate;
using LiCakes.Domain.SeedWork;
using LiCakes.Infra.Data.Interfaces;

namespace LiCakes.Infra.Data
{
  public class UnitOfWork : IUnitOfWork
  {
    private readonly IDatabaseContext _context;
    public IProductRepository ProductRepository { get; }

    public UnitOfWork(
      IContextFactory contextFactory,
      IProductRepository productRepository
      )
    {
      _context = contextFactory.DbContext;
      ProductRepository = productRepository;
    }

    public int Commit()
    {
      return _context.SaveChanges();
    }

    public async Task<int> CommitAsync()
    {
      return await _context.SaveChangesAsync(CancellationToken.None);
    }

    private bool _disposed = false;
    protected virtual void Dispose(bool disposing)
    {
      if (!_disposed)
      {
        if (disposing)
        {
          _context.Dispose();
        }
      }
      _disposed = true;
    }
    public void Dispose()
    {
      Dispose(true);
      GC.SuppressFinalize(this);
    }
  }
}
