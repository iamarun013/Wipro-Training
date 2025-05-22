using System;
using System.Collections.Generic;

// 1. Product class
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}

// 2. CartItem class
public class CartItem
{
    public Product Product { get; set; }
    public int Quantity { get; set; }

    public decimal GetTotalPrice()
    {
        return Product.Price * Quantity;
    }
}

// 3. ShoppingCart class
public class ShoppingCart
{
    private List<CartItem> items = new List<CartItem>();

    public void AddItem(Product product, int quantity)
    {
        // Check if product already exists in cart
        var existingItem = items.Find(item => item.Product.Id == product.Id);
        if (existingItem != null)
        {
            existingItem.Quantity += quantity;
        }
        else
        {
            items.Add(new CartItem { Product = product, Quantity = quantity });
        }
    }

    public void RemoveItem(int productId)
    {
        items.RemoveAll(item => item.Product.Id == productId);
    }

    public decimal GetCartTotal()
    {
        decimal total = 0;
        foreach (var item in items)
        {
            total += item.GetTotalPrice();
        }
        return total;
    }

    public void PrintCartDetails()
    {
        Console.WriteLine("Cart Details:");
        foreach (var item in items)
        {
            Console.WriteLine($"{item.Product.Name} - Quantity: {item.Quantity} - Total: {item.GetTotalPrice():C}");
        }
        Console.WriteLine($"Total Cart Value: {GetCartTotal():C}");
    }
}

class Program
{
    static void Main()
    {
        // 4. Add products
        Product prod1 = new Product { Id = 1, Name = "Laptop", Price = 999.99m };
        Product prod2 = new Product { Id = 2, Name = "Headphones", Price = 199.99m };
        Product prod3 = new Product { Id = 3, Name = "Mouse", Price = 25.50m };

        // Create shopping cart
        ShoppingCart cart = new ShoppingCart();

        // Add items
        cart.AddItem(prod1, 1);
        cart.AddItem(prod2, 2);
        cart.AddItem(prod3, 3);

        // Print total cart value
        cart.PrintCartDetails();
    }
}