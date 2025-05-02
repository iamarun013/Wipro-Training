using System;

public class HelloWorld
{
   static int count=0;
        static int rem;

    static int count_zeros(int n)
    {
        if(n>0)
        {
            rem=n%10;
        if(rem==0)
            count+=1;
            return count_zeros(n/10);
        }
        else
        {
            return count;
        }
    }
    public static void Main(string[] args)
    {
        
        Console.WriteLine ($"Number of zeroes in the number is : {count_zeros(10101)}");
    }
}