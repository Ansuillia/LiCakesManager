using LiCakes.Domain.Enums;
using LiCakes.Domain.Interfaces.Repositories;
using System.Collections.ObjectModel;

namespace LiCakes.Domain.Entities
{
  public class Product : BaseEntity<long>, IEntity
  {
    public string Name { get; private set; }
    public string Description { get; private set; }
    public decimal Price { get; private set; }

    private readonly int _categoryId;
    public Category? Category { get; private set; }

    private readonly List<ProductMaterial> _ingredients;
    public IReadOnlyCollection<ProductMaterial> Ingredients => _ingredients;

    private Product(){}

    public Product(string name, string description, decimal price, string category, string? categoryDescription)
    {
      Name = name;
      Description = description;
      Price = price;
      _ingredients = new List<ProductMaterial>();
    }

    public void AddCategory(string categoryName, string? categoryDescription)
    {
      Category = new Category(categoryName, categoryDescription);
    }

    public void AddIngredient(Material ingredient)
    {
      _ingredients.Add(new ProductMaterial(Id, ingredient.Id));
    }

  }
}
