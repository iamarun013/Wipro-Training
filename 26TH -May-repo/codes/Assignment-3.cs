using System;
using System.Threading;

class Program
{
    static void Main()
    {
        // Define 5 different items to process
        object[] items = { "Item1", "Item2", "Item3", "Item4", "Item5" };

        // Queue each item for processing using ThreadPool
        foreach (var item in items)
        {
            ThreadPool.QueueUserWorkItem(ProcessItem, item);
        }

        // Optional: Wait for user input to prevent the program from exiting immediately
        Console.WriteLine("Processing items... Press any key to exit after tasks complete.");
        Console.ReadKey();
    }

    static void ProcessItem(object item)
    {
        string itemStr = item as string;
        Console.WriteLine($"Processing {itemStr} on thread {Thread.CurrentThread.ManagedThreadId}");
        // Simulate work with a delay
        Thread.Sleep(1000);
        Console.WriteLine($"{itemStr} processed on thread {Thread.CurrentThread.ManagedThreadId}");
    }
}