using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> cities = new Dictionary<string, string> {
        { "Mumbai", "Maharashtra"},
        { "Bangalore", "Karnataka"},
        { "Chennai", "Tamil Nadu"},
        { "Kolkata", "West Bengal"},
        { "Hyderbad", "Telengana"}
    };

        Console.WriteLine("Indian Cities and their states: ");
        foreach (var city in cities)
        {
            Console.WriteLine($"{city.Key} is in {city.Value}");
        }

        if (cities.ContainsKey("Chennai"))
        {
            Console.WriteLine("Chennai is present in the dictionary.");

        }

    }
}
