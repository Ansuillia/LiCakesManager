using LiCakes.Domain.Interfaces.Repositories;
using LiCakes.Infra.Data.Interfaces;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiCakes.Infra.Data.Repositories
{
  public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
  {
    private readonly IDatabaseContext _context;

    protected Repository(IDatabaseContext context)
    {
      _context = context;
    }
    public async Task Create(TEntity entity)
    {
      await _context.Set<TEntity>().AddAsync(entity);
    }

  }
}
