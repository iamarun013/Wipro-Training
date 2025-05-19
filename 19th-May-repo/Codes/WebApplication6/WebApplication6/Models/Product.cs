namespace WebApplication6.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }

        public string Description { get; set; }


        public Category Category { get; set; }

    }
    public class Category
    { 
    public int CategoryID { get; set; }
    public string CategoryName { get; set; }
    public ICollection<Product> Products { get; set; }

    }

}
