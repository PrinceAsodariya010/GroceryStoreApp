using GroceryStoreApp.Models;

namespace GroceryStoreApp.Services
{
    public class DataSeeder
    {
        // ✅ Make list available to all controllers
        public static List<Product> Products = new List<Product>
        {
            new Product { Id = 1, Name = "Apple", Price = 120, ImageUrl = "/images/apple.jpeg" },
            new Product { Id = 2, Name = "Banana", Price = 60, ImageUrl = "/images/banana.jpeg" },
            new Product { Id = 3, Name = "Milk", Price = 50, ImageUrl = "/images/milk.jpeg" },
            new Product { Id = 4, Name = "Bread", Price = 40, ImageUrl = "/images/bread.jpeg" }
        };
    }
}
