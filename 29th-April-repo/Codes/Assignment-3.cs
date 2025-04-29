using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int n=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Multiplication Table");
        for(int i=1;i<=10;i++)
        {
            Console.WriteLine(n*i);
        }
       
    }
}

