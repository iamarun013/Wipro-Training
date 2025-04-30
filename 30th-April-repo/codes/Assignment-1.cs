// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       Random rand=new Random();
       int n=rand.Next(1,12);
       switch(n)
       {
           case 1:Console.WriteLine("January");
           break;
           case 2:Console.WriteLine("February");
           break;
           case 3:Console.WriteLine("March");
           break;
           case 4:Console.WriteLine("April");
           break;
           case 5:Console.WriteLine("May");
           break;
           case 6:Console.WriteLine("June");
           break;
           case 7:Console.WriteLine("July");
           break;
           case 8:Console.WriteLine("August");
           break;
           case 9:Console.WriteLine("September");
           break;
           case 10:Console.WriteLine("October");
           break;
           case 11:Console.WriteLine("November");
           break;
           default:Console.WriteLine("December");
           break;
       }
    }
}