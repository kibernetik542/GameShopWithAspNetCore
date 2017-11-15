using GameWorld.Models;
using GameWorld.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace GameWorld.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository _repository;
        public int PageSize = 4;

        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }

        public ViewResult List(int page = 1) => View(new ProductsListViewModel
        {
            Products = _repository.Products.OrderBy(p => p.ProductID).Skip((page - 1) * PageSize).Take(PageSize),
            PagingInfo = new PagingInfo { CurrentPage = page, ItemsPerPage = PageSize, TotalItems = _repository.Products.Count() }
        });

    }
}