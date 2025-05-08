using System;
using System.Collections.Generic;
using static System.Reflection.Metadata.BlobBuilder;

class Program
{
    static void Main()
    {
        Stack<string> books = new Stack<string>();
        books.Push("C# Programming");
        books.Push("Data Structures");
        books.Push("Machine Learning");

        Console.WriteLine("Books in the stack: ");
        foreach (var book in books)
        {
            Console.WriteLine(books);
        }
        Console.WriteLine("\nPopped:" + books.Pop());

        Console.WriteLine("Next on the stack: " + books.Peek());
    }
}