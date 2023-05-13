namespace LiCakes.Domain.SeedWork
{
  public interface IRepository<TEntity, TKey> 
    where TEntity : class
    where TKey : struct
  {
    Task<TEntity> CreateAsync(TEntity entity);
    Task<TEntity> UpdateAsync(TEntity entity);
    Task DeleteAsync(TKey id);
    Task<TEntity> FindByNameAsync(string name);
    Task<TEntity> FindByIdAsync(TKey id);
  }
}
