using LiCakes.Domain.Aggregates.ProductAggregate;
using LiCakes.Domain.Models;
using LiCakes.Domain.SeedWork;
using LiCakes.Infra.Data.Context;
using LiCakes.Infra.Data.Interfaces;
using LiCakes.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LiCakes.Infra.Data
{
  public static class InfraDataModuleDependency
  {
    public static void AddDatabaseContext(this IServiceCollection services, IConfiguration configuration)
    {
      var contextConnectionString = configuration.GetConnectionString("DefaultConnection");
      
      services.Configure<ConnectionSettings>(x => x.DefaultConnection = contextConnectionString);

      services.AddDbContextPool<LiCakesDbContext>(x => x.UseSqlServer(contextConnectionString, o =>
      {
        o.EnableRetryOnFailure(3);
      }));
      
      services.AddTransient<IContextFactory, SQLServerContextFactory>();
    }

    public static void AddMappings(this IServiceCollection services)
    {
      services.AddAutoMapper(typeof(LiCakesDbContext));
    }

    public static void AddRepositories(this IServiceCollection services)
    {
      services.AddTransient<IProductRepository, ProductRepository>();
    }

    public static void AddUnitOfWork(this IServiceCollection services)
    {
      services.AddScoped<IUnitOfWork, UnitOfWork>();
    }
  }
}
