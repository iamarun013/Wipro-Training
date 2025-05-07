using System;
using System.Collections;

class Program
{
    public static void Main()
    {
        ArrayList numbers = new ArrayList() { 1, 4, 9, 2, 0, -2, -8, -11, 10 };
        numbers.Sort();
        Console.WriteLine("SORTED : ");
        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }

        numbers.Reverse();
        Console.WriteLine("Reversed : ");
        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }

    }
}