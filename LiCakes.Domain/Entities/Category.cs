using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiCakes.Domain.Entities
{
  public class Category : BaseEntity<int>
  {
    public string Name { get; set; }
    public string? Description { get; set; }

    public ICollection<Product> Products { get; set; }

    public Category(string name, string? description) 
    {
      Name = name;
      Description = description;
      Products = new List<Product>();
    }

    public override string ToString()
    {
      return Name.ToUpper();
    }
  }
}
