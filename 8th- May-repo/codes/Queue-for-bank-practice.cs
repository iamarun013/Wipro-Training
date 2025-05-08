using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> customers = new Queue<string>();

        customers.Enqueue("Rajesh");
        customers.Enqueue("Priya");
        customers.Enqueue("Neha");

        Console.WriteLine("Servicing Customers: ");
        while (customers.Count > 0)
        {
            Console.WriteLine("Serving:  " + customers.Dequeue());
        }
    }
}