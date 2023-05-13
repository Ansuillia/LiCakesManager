using AutoMapper;
using LiCakes.Domain.Aggregates.ProductAggregate;
using LiCakes.Infra.Data.DTOs;

namespace LiCakes.Infra.Data.Mappings
{
    public class ProductMapping : Profile 
  {
    public ProductMapping() {
      CreateMap<Product, ProductDTO>();
      CreateMap<ProductDTO, Product>()
        .ForMember(x => x.Category, x => x.Ignore())
        .ForMember(x => x.Ingredients, x => x.Ignore());
    }
  }
}
