using System;
using System.Collections.Generic;
using System.Linq; // Correct namespace for LINQ methods

class Program
{
    public static void Main()
    {
        List<string> students= new List<string>();
        students.Add("Arunava");
        students.Add("Meghoma");
        students.Add("Abir");
        students.Add("Arnab");
        students.Add("Chanda");

        Console.WriteLine("Names of the students");
        foreach(var name in students)
        {
            Console.WriteLine($"Name-: {name}");
        }

        // Sorting using List's Sort() method
        students.Sort();

        Console.WriteLine("Sorted names of the students");
        foreach(var name in students)
        {
            Console.WriteLine($"Name-: {name}");
        }

        // Sorting using LINQ's OrderBy()
        Console.WriteLine("Using LINQ functions:");
        var SortedNames = students.OrderBy(s => s); // Corrected lambda parameter
        foreach(string name in SortedNames)
        {
            Console.WriteLine(name);
        }
    }
}