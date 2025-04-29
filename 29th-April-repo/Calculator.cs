using System;

public class HelloWorld
{
    static int Add(int a, int b)
    {
        return (a+b);
    }
    public static void Main(string[] args)
    {
        int num1=25;
        int num2=10;
        Console.WriteLine("Addition of num1 and num2: "+ Add(num1, num2));
       
    }
}

