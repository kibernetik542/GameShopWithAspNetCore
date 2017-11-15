using System.Collections.Generic;

namespace GameWorld.Models
{
    public class EFProductRepository : IProductRepository
    {
        private ApplicationDbContext context;

        public EFProductRepository(ApplicationDbContext context)
        {
            this.context = context;
        }


        public IEnumerable<Product> Products => context.Products;
    }
}
