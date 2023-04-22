using LiCakes.Domain.Interfaces.Repositories;

namespace LiCakes.Domain.Entities
{
  public class Purchase : BaseEntity<long>, IEntity
  {
    public string Supplier { get; private set; }
    public DateOnly PurchaseDate { get; private set; }
    public decimal TotalValue { get; private set; }

    private readonly List<PurchaseMaterial> _itens;
    public IReadOnlyCollection<PurchaseMaterial> Itens => _itens;

    public Purchase(string supplier, DateOnly purchaseDate)
    {
      Supplier = supplier;
      PurchaseDate = purchaseDate;
      _itens = new List<PurchaseMaterial>();
    }

    public void AddItens(PurchaseMaterial material)
    {
      _itens.Add(material);
    }
  }
}
