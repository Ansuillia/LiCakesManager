using AutoMapper;
using LiCakes.Application.Services.Interfaces;
using LiCakes.Domain.Aggregates.ProductAggregate;
using LiCakes.Domain.Agregates;
using LiCakes.Domain.SeedWork;
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
        Category category = null;

        if (string.IsNullOrWhiteSpace(product.Category))
          category = await _uow.ProductRepository.FindOrCreateCategory("Default", "Deafault category");
        else
          category = await _uow.ProductRepository.FindOrCreateCategory(product.Category, "");

        var newProduct = _mapper.Map<Product>(product);
        newProduct.AddCategory(category);

        var inserted = await _uow.ProductRepository.CreateAsync(newProduct);

        _uow.Commit();

        return _mapper.Map<ProductDTO>(inserted);
      }
      catch (Exception)
      {
        throw;
      }

    }
  }
}
