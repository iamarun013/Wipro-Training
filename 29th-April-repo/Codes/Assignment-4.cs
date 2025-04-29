using System;

public class HelloWorld
{
    static int largest(int a, int b, int c){
        if(a>b && a>c)
        return a;
        if(b>a && b>c)
        return b;
        else
        return c;
        
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter three numbers:");
        int n1=Convert.ToInt32(Console.ReadLine());
        int n2=Convert.ToInt32(Console.ReadLine());
        int n3=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Largest number among the three given numbers is-");
        Console.WriteLine(largest(n1, n2, n3));
       
    }
}

