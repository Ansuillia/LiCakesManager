using LiCakes.Domain.Agregates;
using LiCakes.Domain.Entities;
using LiCakes.Domain.Enums;
using LiCakes.Domain.SeedWork;

namespace LiCakes.Domain.Aggregates.ProductAggregate
{
  public class Product : BaseEntity<long>, IAggregateRoot
  {
    public string Name { get; private set; }
    public string Description { get; private set; }
    public decimal Price { get; private set; }

    public virtual Category Category { get; private set; }

    private readonly List<ProductIngredient> _ingredients;
    public IReadOnlyCollection<ProductIngredient> Ingredients => _ingredients;

    private Product() { }

    public Product(string name, string description, decimal price, Category category)
    {
      Name = name;
      Description = description;
      Price = price;
      Category = category;
      _ingredients = new List<ProductIngredient>();
    }

    public void AddIngredient(Material ingredient, int quantity)
    {
      _ingredients.Add(new ProductIngredient(Id, ingredient.Id, quantity));
    }

  }
}
