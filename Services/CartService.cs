using GroceryStoreApp.Models;

namespace GroceryStoreApp.Services
{
    public class CartService
    {
        private List<CartItem> cart = new();

        public void AddToCart(Product product)
        {
            var existing = cart.FirstOrDefault(c => c.Product.Id == product.Id);
            if (existing != null)
                existing.Quantity++;
            else
                cart.Add(new CartItem { Product = product, Quantity = 1 });
        }

        public List<CartItem> GetCart() => cart;
        public void ClearCart() => cart.Clear();
    }
}
