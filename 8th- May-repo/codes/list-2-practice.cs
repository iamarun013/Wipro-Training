using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> fruits = new List<string>() { "Apple", "Banana", "Cherry" };

        fruits.Add("Mango");
        fruits.Insert(1, " Orange");
        fruits.Remove("Banana");
        fruits.RemoveAt(2);
        if (fruits.Contains("Apple")) ;
        {
            Console.WriteLine("Apple is in the List");
        }

        fruits.Sort();

        Console.WriteLine("Fruits Lists:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine("Fruits ");
        }
    }
}