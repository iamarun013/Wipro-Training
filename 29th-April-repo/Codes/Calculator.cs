using System;

public class HelloWorld
{
    static int add(int a, int b)
    {
        return (a+b);
    }
    
    static int multiply(int a, int b)
    {
        return (a*b);
    }
    static int substract(int a, int b)
    {
        if(a>b)
        return (a-b);
        else
        return (b-a);
    }
    static double divison(double a, double b)
    {
        if(a>b)
        return (a/b);
        else
        return (b/a);
    }
    public static void Main(string[] args)
    {
        int num1=25;
        int num2=10;
        Console.WriteLine("Addition of num1 and num2: "+ add(num1, num2));
        Console.WriteLine("Substraction of num1 and num2: "+ substract(num1, num2));
        Console.WriteLine("Multiplication of num1 and num2: "+ multiply(num1, num2));
        Console.WriteLine("Divison of num1 and num2: "+ divison(num1, num2));
       
    }
}

