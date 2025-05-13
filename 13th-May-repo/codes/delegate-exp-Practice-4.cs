using System;

class SimpleDelegate
{
    public delegate int SomeOperation(int i, int j);
}

class Function
{
    static int Sum(int x, int y)
    {
        return x + y;
    }
    // Assign the Sum method to a Func delegate
    //first two ints are parameters to the functtion a and the last one is return type, we  here are not just using delegate keyword, we are using func to use this aas like a delegate


    static void Main(string[] args)
    {
        Func<int, int, int> add = Sum;

        // Invoke the delegate
        int result = add(10, 10);

        Console.WriteLine(result);
    }
}
//     
//         // Use the delegate type from SimpleDelegate
//         SimpleDelegate.SomeOperation add = Sum;
//         int result = add(10, 10);
//         Console.WriteLine(result);
//
