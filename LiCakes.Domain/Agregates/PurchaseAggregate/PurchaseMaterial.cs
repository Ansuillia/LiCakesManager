using LiCakes.Domain.SeedWork;

namespace LiCakes.Domain.Aggregates.PurchaseAgregate
{
  public class PurchaseMaterial : BaseEntity<long>, IEntity
  {
    public long PurchaseId { get; private set; }
    public long MaterialId { get; private set; }
    public decimal Price { get; private set; }
    public int Quantity { get; private set; }

    public PurchaseMaterial(long purchaseId, long materialId, int quantity, decimal price)
    {
      PurchaseId = purchaseId;
      MaterialId = materialId;
      Price = price;
      Quantity = quantity;
    }
  }
}
