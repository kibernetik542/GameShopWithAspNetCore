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

        public ViewResult List(string category, int page = 1) => View(new ProductsListViewModel
        {
            Products = _repository.Products
            .Where(p => category == null || p.Category == category)
            .OrderBy(p => p.ProductID).Skip((page - 1) * PageSize)
            .Take(PageSize),
            PagingInfo = new PagingInfo
            {
                CurrentPage = page,
                ItemsPerPage = PageSize,
                TotalItems = category == null ? _repository.Products.Count() : _repository.Products.Count(x => x.Category == category)
            },
            CurrentCategory = category
        });

    }
}