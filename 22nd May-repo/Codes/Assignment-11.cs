using System;
using System.Collections.Generic;
using System.Linq;

// 1. Define the Product class
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}

class Program
{
    static void Main()
    {
        // 2. Add 5–6 products to a list
        List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 999.99m },
            new Product { Id = 2, Name = "Smartphone", Price = 599.99m },
            new Product { Id = 3, Name = "Headphones", Price = 199.99m },
            new Product { Id = 4, Name = "Monitor", Price = 299.99m },
            new Product { Id = 5, Name = "Keyboard", Price = 49.99m },
            new Product { Id = 6, Name = "Mouse", Price = 29.99m }
        };

        // 3. Sort the products by price in descending order using LINQ
        var sortedProducts = products
            .OrderByDescending(p => p.Price)
            .ToList();

        // 4. Print the sorted list
        Console.WriteLine("Products sorted by price (descending):");
        foreach (var product in sortedProducts)
        {
            Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price:C}");
        }
    }
}