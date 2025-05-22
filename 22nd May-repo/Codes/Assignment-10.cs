using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // 1. Create a List<int> with some repeated numbers
        List<int> numbers = new List<int> { 4, 8, 15, 16, 23, 42, 8, 15, 4, 42, 42 };

        // 2. Use LINQ to find numbers that appear more than once
        var duplicates = numbers
            .GroupBy(n => n)                  // Group by number
            .Where(g => g.Count() > 1)        // Select groups with count > 1
            .Select(g => g.Key)               // Get the number (key) from each group
            .Distinct();                      // Ensure unique duplicate numbers

        // 3. Print the duplicated numbers
        Console.WriteLine("Duplicated numbers:");
        foreach (var num in duplicates)
        {
            Console.WriteLine(num);
        }
    }
}