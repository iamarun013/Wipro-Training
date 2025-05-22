using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // 1. Create a List<int> with at least 10 numbers
        List<int> numbers = new List<int> { 3, 8, 15, 22, 7, 10, 13, 4, 19, 6 };

        // 2. Use LINQ to filter even numbers
        var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();

        // Use LINQ to filter odd numbers
        var oddNumbers = numbers.Where(n => n % 2 != 0).ToList();

        // 3. Print both lists
        Console.WriteLine("Even Numbers:");
        foreach (var num in evenNumbers)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine("\nOdd Numbers:");
        foreach (var num in oddNumbers)
        {
            Console.WriteLine(num);
        }
    }
}