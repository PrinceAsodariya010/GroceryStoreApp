using GroceryStoreApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace GroceryStoreApp.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly CartService _cartService;

        public CheckoutController(CartService cartService)
        {
            _cartService = cartService;
        }

        public IActionResult Index()
        {
            var cart = _cartService.GetCart();
            if (cart.Count == 0)
            {
                TempData["Error"] = "Your cart is empty!";
                return RedirectToAction("Index", "Cart");
            }

            _cartService.ClearCart();
            return View();
        }
    }
}
