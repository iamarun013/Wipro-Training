
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int n=1;
        while((n*n)<100)
        {
            Console.WriteLine(n*n);
            n=n+1;
        }
    }
}