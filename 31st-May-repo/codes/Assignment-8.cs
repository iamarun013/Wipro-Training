using System;
using System.Collections.Generic;

// Interface for printing
public interface IPrintable
{
    void Print();
}

// Product class
public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }

    public Product(string name, decimal price, int qty)
    {
        Name = name;
        Price = price;
        Quantity = qty;
    }

    public decimal GetTotal()
    {
        return Price * Quantity;
    }
}

// Abstract class Invoice
public abstract class Invoice : IPrintable
{
    public List<Product> Products { get; set; } = new List<Product>();
    public decimal TaxRate { get; set; } // e.g., 0.05 for 5%
    public decimal Discount { get; set; } // e.g., 10 for $10 off

    public Invoice(decimal taxRate, decimal discount)
    {
        TaxRate = taxRate;
        Discount = discount;
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    // Abstract method to calculate total
    public abstract decimal CalculateTotal();

    // Implement Print method from IPrintable
    public virtual void Print()
    {
        Console.WriteLine("----- Invoice -----");
        Console.WriteLine("Product List:");
        foreach (var p in Products)
        {
            Console.WriteLine($"{p.Name} - {p.Quantity} x {p.Price:C} = {p.GetTotal():C}");
        }

        decimal subtotal = 0;
        foreach (var p in Products)
        {
            subtotal += p.GetTotal();
        }

        decimal taxAmount = subtotal * TaxRate;
        decimal totalBeforeDiscount = subtotal + taxAmount;
        decimal total = totalBeforeDiscount - Discount;

        Console.WriteLine($"Subtotal: {subtotal:C}");
        Console.WriteLine($"Tax (@{TaxRate:P}): {taxAmount:C}");
        Console.WriteLine($"Discount: {Discount:C}");
        Console.WriteLine($"Total: {total:C}");
        Console.WriteLine("-------------------");
    }
}

// RetailInvoice subclass
public class RetailInvoice : Invoice
{
    public RetailInvoice(decimal taxRate, decimal discount) : base(taxRate, discount) { }

    public override decimal CalculateTotal()
    {
        decimal subtotal = 0;
        foreach (var p in Products)
        {
            subtotal += p.GetTotal();
        }
        decimal taxAmount = subtotal * TaxRate;
        decimal total = subtotal + taxAmount - Discount;
        return total;
    }
}

// WholesaleInvoice subclass
public class WholesaleInvoice : Invoice
{
    public WholesaleInvoice(decimal taxRate, decimal discount) : base(taxRate, discount) { }

    public override decimal CalculateTotal()
    {
        decimal subtotal = 0;
        foreach (var p in Products)
        {
            subtotal += p.GetTotal();
        }
        // Assume wholesale has a different tax or discount logic if needed
        decimal taxAmount = subtotal * TaxRate;
        decimal total = subtotal + taxAmount - Discount;
        return total;
    }
}

// Main program
class Program
{
    static void Main(string[] args)
    {
        // Create a retail invoice
        RetailInvoice retailInvoice = new RetailInvoice(0.07m, 5m); // 7% tax, $5 discount
        retailInvoice.AddProduct(new Product("Book", 12.99m, 2));
        retailInvoice.AddProduct(new Product("Pen", 1.50m, 10));

        // Create a wholesale invoice
        WholesaleInvoice wholesaleInvoice = new WholesaleInvoice(0.05m, 20m); // 5% tax, $20 discount
        wholesaleInvoice.AddProduct(new Product("Notebook", 8.00m, 50));
        wholesaleInvoice.AddProduct(new Product("Marker", 2.00m, 100));

        // Print invoices
        retailInvoice.Print();
        wholesaleInvoice.Print();
    }
}