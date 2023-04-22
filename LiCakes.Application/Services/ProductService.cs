using AutoMapper;
using LiCakes.Application.Services.Interfaces;
using LiCakes.Domain.Entities;
using LiCakes.Infra.Data;
using LiCakes.Infra.Data.DTOs;

namespace LiCakes.Application.Services
{
  public class ProductService : IProductService
  {
    private readonly IUnitOfWork _uow;
    private readonly IMapper _mapper;

    public ProductService(IUnitOfWork uow, IMapper mapper)
    {
      _uow = uow;
      _mapper = mapper;
    }
    public async Task<ProductDTO> CreateProduct(ProductDTO product)
    {
      if (product == null)
        throw new ArgumentNullException(nameof(product));
      try
      {
        var newProduct = _mapper.Map<Product>(product);

        await _uow.ProductRepository.Create(newProduct);

        _uow.Commit();

        return _mapper.Map<ProductDTO>(newProduct);
      }
      catch (Exception)
      {
        throw;
      }

    }
  }
}
