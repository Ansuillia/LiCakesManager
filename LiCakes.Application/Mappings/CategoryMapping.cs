using AutoMapper;
using LiCakes.Domain.Agregates;
using LiCakes.Infra.Data.DTOs;

namespace LiCakes.Infra.Data.Mappings
{
    public class CategoryMapping : Profile
  {
    public CategoryMapping()
    {
      CreateMap<Category, CategoryDTO>();
      CreateMap<CategoryDTO, Category>();
    }
  }
}
