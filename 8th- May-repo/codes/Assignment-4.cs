using System;
using System.Collections.Generic;
using System.Linq; // Needed for OrderByDescending

// Class representing store item information
class StoreInfo
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }
}

class Program
{
    public static void Main()
    {
        // Initialize list of products
        List<StoreInfo> Product = new List<StoreInfo>
        {
            new StoreInfo { ID=1, Name="Rice", Price=50 },
            new StoreInfo { ID=2, Name="Daal", Price=70 },
            new StoreInfo { ID=3, Name="Chicken", Price=200 },
            new StoreInfo { ID=4, Name="Detergent", Price=300 },
            new StoreInfo { ID=5, Name="Sauce", Price=120 }
        };

        // Sort the list in descending order based on price
        var sortedList = Product.OrderByDescending(p => p.Price).ToList();

        // Display sorted list
        foreach (var p in sortedList)
        {
            Console.WriteLine($"ID: {p.ID}, Name: {p.Name}, Price: {p.Price}");
        }

        Console.WriteLine();

        // Display the most expensive product
        var topProduct = sortedList[0];
        Console.WriteLine($"Most expensive item: ID: {topProduct.ID}, Name: {topProduct.Name}, Price: {topProduct.Price}");
    }
}