using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // 1. Create a List<string> with 8–10 names
        List<string> names = new List<string>
        {
            "Alice",
            "Ethan",
            "Ian",
            "Oliver",
            "Uma",
            "Bob",
            "Charlie",
            "Andrew",
            "Emily",
            "Oscar"
        };

        // 2. Use LINQ to find names starting with vowels (A, E, I, O, U)
        var vowelNames = names
            .Where(name => !string.IsNullOrEmpty(name) && 
                           "AEIOUaeiou".Contains(name[0]))
            .ToList();

        // 3. Print the result
        Console.WriteLine("Names starting with a vowel:");
        foreach (var name in vowelNames)
        {
            Console.WriteLine(name);
        }
    }
}