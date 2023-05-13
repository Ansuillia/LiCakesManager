using LiCakes.Domain.SeedWork;
using LiCakes.Infra.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LiCakes.Infra.Data.Repositories
{
  public abstract class Repository<TEntity, TKey> : IRepository<TEntity, TKey>
    where TEntity : class
    where TKey : struct
  {
    protected readonly IDatabaseContext _context;
    protected readonly DbSet<TEntity> _dbSet;

    protected Repository(IDatabaseContext context)
    {
      _context = context;
      _dbSet = _context.Set<TEntity>();
    }

    public async Task DeleteAsync(TKey id)
    {
      var entity = await _context.Set<TEntity>().FindAsync(id);
      if(entity is not null)
        _dbSet.Remove(entity);
    }

    public async Task<TEntity> FindByIdAsync(TKey id)
    {
      return await _dbSet.FindAsync(id);
    }

    public async Task<TEntity> FindByNameAsync(string name)
    {
      return await _dbSet.FindAsync(name);
    }

    public Task<TEntity> UpdateAsync(TEntity entity)
    {
      var result = _dbSet.Update(entity);
      return Task.FromResult(result.Entity);
    }

    public Task<TEntity> CreateAsync(TEntity entity)
    {
      var createdEntity = _dbSet.Add(entity);
      return Task.FromResult(createdEntity.Entity);
    }
  }
}
