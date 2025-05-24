using System;
using System.Threading;

class Program{
    static void Main()
    {
        object[] items={"Item1", "Item2", "Item3", "Item4", "Item5"};

        foreach(var item in items)
        {
            Threadpool.QueueUserWorkItem(ProcessItem, item);
        }

        Console.WriteLine("Tasks queued. Press Enter to exit");
        Console.ReadLine();

    }
    static void ProcessItem(object item)

{
    string itemName=item as string;
    Console.WriteLine($"Processing {itemName} on thread {Thread.CurrentThread.ManagedThreadId}");
    Thread.Sleep(1000);
    Console.WriteLine($"Finished processing {itemName on thread {Thread.CurrentThread.ManagedThreadId}}");
}
}