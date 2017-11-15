using System.Collections.Generic;

namespace GameWorld.Models
{
    public class FakeRepository : IProductRepository
    {
        public IEnumerable<Product> Products => new List<Product>
        {
            new Product{Name = "Uncharted 4",Price = 35.94M},
            new Product{Name = "Assassin's Creeed Origins",Price = 68.18M},
            new Product{Name = "The Evil Within 2",Price = 58.16M},
        };
    }
}
