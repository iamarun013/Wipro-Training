using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        var task1 = RiskyTaskAsync("Task1", false);
        var task2 = RiskyTaskAsync("Task2", true); // This will throw
        var task3 = RiskyTaskAsync("Task3", false);

        try
        {
            await Task.WhenAll(task1, task2, task3);
        }
        catch (Exception ex)
        {
            if (task2.IsFaulted)
                Console.WriteLine("Task2 failed with exception: " + ex.InnerException?.Message);
            else if (task1.IsFaulted)
                Console.WriteLine("Task1 failed with exception: " + ex.InnerException?.Message);
            else if (task3.IsFaulted)
                Console.WriteLine("Task3 failed with exception: " + ex.InnerException?.Message);
        }
    }

    static async Task RiskyTaskAsync(string name, bool throwError)
    {
        await Task.Delay(500);
        if (throwError)
            throw new InvalidOperationException($"{name} encountered an error.");
        Console.WriteLine($"{name} completed successfully.");
    }
}