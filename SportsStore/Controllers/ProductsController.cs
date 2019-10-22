using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

namespace SportsStore.Controllers
{
    public class ProductsController : Controller
    {
        private ISportsStoreRepository repository;

        public ProductsController(ISportsStoreRepository repository)
        {
            this.repository = repository;
        }

        public IActionResult Index()
        {
            return View(repository.Products);
        }
    }
}
