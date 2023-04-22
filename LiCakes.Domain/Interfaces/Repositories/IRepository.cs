using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiCakes.Domain.Interfaces.Repositories
{
  public interface IRepository<TEntity> where TEntity : class
  {
    Task Create(TEntity entity);
  }
}
