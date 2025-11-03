namespace GroceryStoreApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public decimal Price { get; set; }

        // ✅ Add ImageUrl property
        public required string ImageUrl { get; set; }
    }
}
