using LiCakes.Domain.Interfaces.Repositories;

namespace LiCakes.Domain.Entities
{
  public abstract class BaseEntity<T> where T : struct
  {
    public T Id { get; set; }
  }
}
