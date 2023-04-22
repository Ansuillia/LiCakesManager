using AutoMapper;
using LiCakes.Domain.Entities;
using LiCakes.Infra.Data.DTOs;

namespace LiCakes.Infra.Data.Mappings
{
  public class ProductMapping : Profile 
  {
    public ProductMapping() {
      CreateMap<Product, ProductDTO>();
      CreateMap<ProductDTO, Product>();
    }
  }
}
