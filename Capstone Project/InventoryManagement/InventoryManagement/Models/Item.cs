using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Models
{
    public class Item
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Item Name is required")]
        [StringLength(100)]
        public string Name { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1")]
        public int quantity { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be more than 0")]
        public decimal price { get; set; }

        [Required(ErrorMessage = "Category is required")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Supplier is required")]
        public string Supplier { get; set; }
    }
}
