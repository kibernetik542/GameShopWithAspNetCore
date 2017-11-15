using System.Collections.Generic;

namespace GameWorld.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
    }
}
