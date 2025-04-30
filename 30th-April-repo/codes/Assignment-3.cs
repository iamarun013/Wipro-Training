using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
      int n;
      Console.WriteLine("Enter a number");
      n=Convert.ToInt32(Console.ReadLine());
      int rem; int sum=0;
      Console.WriteLine($"Random number taken {n}");
      while(n>0){
          rem=n%10;
          sum=(sum*10)+rem;
          n=n/10;
      };
            Console.WriteLine($"Reversed no. is {sum}");

    }
}