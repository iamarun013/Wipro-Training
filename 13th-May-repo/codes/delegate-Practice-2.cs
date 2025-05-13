using System;

// Define the delegate outside any method or class
delegate void CustomDel(string s);

class TestClass
{
    // Define methods matching the delegate signature
    static void Hello(string s)
    {
        Console.WriteLine($"Hello, {s}!");
    }

    static void Main()
    {
        // Declare an instance of the delegate
        CustomDel hiDel;

        // Assign the method 'Hello' to the delegate
        hiDel = Hello;

        Console.WriteLine("Invoking delegate hiDel:");
        // Invoke the delegate
        hiDel("A");
    }
}