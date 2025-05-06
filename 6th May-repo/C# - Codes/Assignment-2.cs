using System;
using System.Diagnostics.CodeAnalysis;
class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a number to check it's summ");
        int n=Convert.ToInt32(Console.ReadLine());
        int rem, sum;
        sum = 0;
        while(n>0)
        {
            rem = n % 10;
            sum=sum+rem;
            n = n / 10;
         }
        Console.WriteLine($"Sum is {sum}");
    }


}

