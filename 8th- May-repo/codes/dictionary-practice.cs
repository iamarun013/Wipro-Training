using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //Creating A dictionary to store student IDs, and names
        Dictionary<int, string> students = new Dictionary<int, string>();
        students.Add(101, "Alice");
        students.Add(102, "Bob");
        students.Add(103, "Charlie");

        //accessing values using keys
        Console.WriteLine("students with ID 102: " + students[102]);

        foreach( var pair in students)
        {
            Console.WriteLine($"ID: {pair.Key}, Name: {pair.Value}");
        }

    }
}