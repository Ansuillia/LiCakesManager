using LiCakes.Domain.SeedWork;

namespace LiCakes.Domain.Aggregates.ProductAggregate
{
  public class ProductIngredient : BaseEntity<long>, IEntity
  {
    public long ProductId { get; private set; }
    public long MaterialId { get; private set; }
    public int Quantity { get; private set; }

    public ProductIngredient(long productId, long materialId, int quantity)
    {
      ProductId = productId;
      MaterialId = materialId;
      Quantity = quantity;
    }
  }
}
