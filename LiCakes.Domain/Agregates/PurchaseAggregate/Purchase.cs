using LiCakes.Domain.Entities;
using LiCakes.Domain.SeedWork;

namespace LiCakes.Domain.Aggregates.PurchaseAgregate
{
  public class Purchase : BaseEntity<long>, IAggregateRoot
  {
    public string Supplier { get; private set; }
    public DateOnly PurchaseDate { get; private set; }
    public decimal TotalValue => _itens.Sum(x => x.Price);

    private readonly List<PurchaseMaterial> _itens;
    public IReadOnlyCollection<PurchaseMaterial> Itens => _itens;

    public Purchase(string supplier, DateOnly purchaseDate)
    {
      Supplier = supplier;
      PurchaseDate = purchaseDate;
      _itens = new List<PurchaseMaterial>();
    }

    public void AddItens(Material material, int quantity, decimal price)
    {
      _itens.Add(new PurchaseMaterial(Id, material.Id, quantity, price));
    }
  }
}
