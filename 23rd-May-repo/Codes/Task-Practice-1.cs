using System;
using System.Threading.Tasks;

class Program{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Work Started. ");
        await DoAsyncWork();
        Console.WriteLine("Work completed.");
    }

    static async Task DoAsyncWork()
    {
        Console.WriteLine("Working asynchronously..");
        await Task.Delay(2000);//Simulate 3 seconds of delay
        Console.WriteLine("Async work done.");
    }
}