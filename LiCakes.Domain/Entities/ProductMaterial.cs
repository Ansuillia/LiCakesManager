using LiCakes.Domain.Interfaces.Repositories;

namespace LiCakes.Domain.Entities
{
  public class ProductMaterial : BaseEntity<long>, IEntity
  {
    public long ProductId { get; private set; }
    public long MaterialId { get; private set; }

    public ProductMaterial(long productId, long materialId)
    {
      ProductId = productId;
      MaterialId = materialId;
    }
  }
}
