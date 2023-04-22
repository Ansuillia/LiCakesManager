using LiCakes.Application.Services;
using LiCakes.Application.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace LiCakes.Application
{
  public static class ApplicationDependecyModule
  {
    public static void AddApplicationService(this IServiceCollection services)
    {
      services.AddScoped<IProductService, ProductService>();
    }
  }
}
