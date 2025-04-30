

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int n=11111225;
        int no=n;
        int sum=0;
        int rem;
        do{
            rem=no%10;
            sum+=rem;
            no=no/10;
            
        }while(no>0);
        Console.WriteLine($"Sum of digits of {n} is {sum}");
    }
}