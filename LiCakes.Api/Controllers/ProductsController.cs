using LiCakes.Application.Services.Interfaces;
using LiCakes.Infra.Data.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LiCakes.Api.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ProductsController : ControllerBase
  {
    private readonly IProductService _service;
    public ProductsController(IProductService service)
    {
      _service = service;
    }

    [HttpPost]
    public async Task<IActionResult> CreateProduct(ProductDTO productDTO)
    {
      if (productDTO is null) return BadRequest();

      var product = await _service.CreateProduct(productDTO);

      return Ok(product);
    }
  }
}
