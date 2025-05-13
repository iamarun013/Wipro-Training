using System;

class SimpleDelegate
{
    public delegate int SomeOperation(int i, int j);
}

class Program
{
    static int Sum(int x, int y)
    {
        return x + y;
    }

    static void Main(string[] args)
    {
        // Use the delegate type from SimpleDelegate
        SimpleDelegate.SomeOperation add = Sum;
        int result = add(10, 10);
        Console.WriteLine(result);
    }
}