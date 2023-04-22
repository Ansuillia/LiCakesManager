using LiCakes.Domain.Enums;

namespace LiCakes.Domain.Entities
{
  public class Material : BaseEntity<long>
  {
    public string Name { get; private set; }
    public EnumUnity Unity { get; private set; }

    private readonly IList<Purchase> _purchases;
    public IList<Purchase> Purchases => _purchases;

    public Material(string name, EnumUnity unity)
    {
      Name = name;
      Unity = unity;
      _purchases = new List<Purchase>();
    }

    public void AddPurchase(Purchase purchase)
    {
      _purchases.Add(purchase);
    }
  }
}
