using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using System.Linq;

namespace SportsStore.Controllers
{
    public class ProductsController : Controller
    {
        private const int NUMBER_PRODUCTS_PER_PAGE = 3;
        private ISportsStoreRepository repository;
        public ProductsController(ISportsStoreRepository repository)
        {
            this.repository = repository;
        }

        public IActionResult Index(int page = 1)
        {
            return View(repository.Products
                .OrderBy(p=>p.Price)
                .Skip((page-1)*NUMBER_PRODUCTS_PER_PAGE)
                .Take(NUMBER_PRODUCTS_PER_PAGE)
                );
        }
    }
}
