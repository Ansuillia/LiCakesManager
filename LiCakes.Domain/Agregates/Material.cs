using LiCakes.Domain.Aggregates.PurchaseAgregate;
using LiCakes.Domain.Enums;
using LiCakes.Domain.SeedWork;

namespace LiCakes.Domain.Entities
{
  public class Material : BaseEntity<long>, IEntity
  {
    public string Name { get; private set; }
    public EnumUnity Unity { get; private set; }

    public Material(string name, EnumUnity unity)
    {
      Name = name;
      Unity = unity;
    }
  }
}
