using System;

public class HelloWorld
{
    static bool calc(int n)
    {
        if(n%2==0)
        return true;
        else
        return false;
    }
   
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int n=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Even or odd: ");
        if(calc(n)){
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("Odd");
        }
       
    }
}

