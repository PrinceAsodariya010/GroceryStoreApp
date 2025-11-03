using GroceryStoreApp.Models;
using GroceryStoreApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace GroceryStoreApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult MyView()
        {
            var vm = new HomeViewModel
            {
                Products = DataSeeder.Products
            };
            return View(vm);
        }
    }
}
