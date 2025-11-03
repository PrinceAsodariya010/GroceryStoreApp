using GroceryStoreApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace GroceryStoreApp.Controllers
{
    public class CartController : Controller
    {
        private readonly CartService _cartService;

        public CartController(CartService cartService)
        {
            _cartService = cartService;
        }

        public IActionResult Add(int id)
        {
            var product = DataSeeder.Products.FirstOrDefault(p => p.Id == id);
            if(product != null)
            {
                _cartService.AddToCart(product);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            return View(_cartService.GetCart());
        }

        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PlaceOrder()
        {
            _cartService.ClearCart();
            return Content("✅ Order placed successfully!");
        }
    }
}
