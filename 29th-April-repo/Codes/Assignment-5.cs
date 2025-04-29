using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Fetching a Random Number between 1-7");
        Random rand=new Random();
        int n= rand.Next(1,7);
        Console.WriteLine("Number fetched is "+ n);
        if(n==1){
        Console.WriteLine("Monday");
        }
        else if(n==2)
        {
            Console.WriteLine("Tuesday");
        }
        else if(n==3)
        {
            Console.WriteLine("Wednesday");
        }
        else if(n==4)
        {
            Console.WriteLine("Thursday");
        }
        else if(n==5)
        {
            Console.WriteLine("Friday");
        }
        else if(n==6)
        {
            Console.WriteLine("Saturday");
        }
        else
        {
            Console.WriteLine("Sunday");
        }
    }
}

