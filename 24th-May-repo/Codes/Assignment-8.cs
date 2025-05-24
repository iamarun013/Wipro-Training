using System;
using System.Threading.Tasks;

class Program
{
    static async Task RiskyTaskAsync(string name, bool shouldFail)
    {
        Console.WriteLine($"{name} started.");
        await Task.Delay(1000); // Simulate some work

        if (shouldFail)
        {
            throw new InvalidOperationException($"{name} encountered an error.");
        }

        Console.WriteLine($"{name} completed successfully.");
    }

    static async Task Main()
    {
        // Create tasks, with one designed to throw an exception
        var task1 = RiskyTaskAsync("Task1", false);
        var task2 = RiskyTaskAsync("Task2", true); // This will throw
        var task3 = RiskyTaskAsync("Task3", false);

        try
        {
            // Await all tasks
            await Task.WhenAll(task1, task2, task3);
        }
        catch (Exception ex)
        {
            // Handle exception
            Console.WriteLine($"An exception occurred: {ex.Message}");

            // Check which task failed
            if (task1.IsFaulted)
            {
                Console.WriteLine($"Task1 failed with: {task1.Exception?.InnerException?.Message}");
            }
            if (task2.IsFaulted)
            {
                Console.WriteLine($"Task2 failed with: {task2.Exception?.InnerException?.Message}");
            }
            if (task3.IsFaulted)
            {
                Console.WriteLine($"Task3 failed with: {task3.Exception?.InnerException?.Message}");
            }
        }
    }
}