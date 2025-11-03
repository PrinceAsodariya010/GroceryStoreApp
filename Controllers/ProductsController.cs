using GroceryStoreApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace GroceryStoreApp.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult List()
        {
            return View(DataSeeder.Products);
        }

        public IActionResult Details(int id)
        {
            var product = DataSeeder.Products.FirstOrDefault(x => x.Id == id);
            return View(product);
        }
    }
}
