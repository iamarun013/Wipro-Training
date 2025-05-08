using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        // Initialize list
        List<int> list = new List<int>();
        Random rand = new Random();

        // Fill list with 10 random numbers between 1 and 7
        for (int i = 0; i < 10; i++)
        {
            list.Add(rand.Next(1, 8));
        }

        // Create a HashSet to store unique elements
        HashSet<int> uniqueList = new HashSet<int>();

        // Add elements from list to the HashSet
        for (int i = 0; i < list.Count; i++)
        {
            uniqueList.Add(list[i]);
        }

        // Print all unique elements
        foreach (var item in uniqueList)
        {
            Console.WriteLine(item);
        }

        // Print count of unique elements
        Console.WriteLine($"Number of unique elements in the HashSet is: {uniqueList.Count}");
    }
}