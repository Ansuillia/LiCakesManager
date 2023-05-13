using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiCakes.Domain.Aggregates.ProductAggregate;
using LiCakes.Domain.SeedWork;

namespace LiCakes.Domain.Agregates
{
    public class Category : BaseEntity<int>, IEntity
    {
        public string Name { get; set; }
        public string? Description { get; set; }

        //public ICollection<Product> Products { get; set; }

        public Category(string name, string? description)
        {
            Name = name;
            Description = description;
        }

        public override string ToString()
        {
            return Name.ToUpper();
        }
    }
}
