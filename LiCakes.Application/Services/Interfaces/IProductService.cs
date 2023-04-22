using LiCakes.Infra.Data.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiCakes.Application.Services.Interfaces
{
  public interface IProductService
  {
    Task<ProductDTO> CreateProduct(ProductDTO product);
  }
}
