using System;
using System.Diagnostics;
using System.Threading.Tasks;

class Program
{
    static async Task SimulateWorkAsync(string name, int delay)
    {
        Console.WriteLine($"{name} started.");
        await Task.Delay(delay);
        Console.WriteLine($"{name} completed");
    }

    static async Task Main()
    {
        var stopwatch = new Stopwatch();

        // Sequential execution
        Console.WriteLine("Sequential execution:");
        stopwatch.Start();
        await SimulateWorkAsync("Task1", 1000);
        await SimulateWorkAsync("Task2", 2000);
        await SimulateWorkAsync("Task3", 3000);
        stopwatch.Stop();
        Console.WriteLine($"Sequential execution time: {stopwatch.ElapsedMilliseconds}ms");


        // Parallel execution
        Console.WriteLine("\nParallel execution:");
        stopwatch.Restart();
        var tasks = new List<Task>();
        tasks.Add(SimulateWorkAsync("Task1", 1000));
        tasks.Add(SimulateWorkAsync("Task2", 2000));
        tasks.Add(SimulateWorkAsync("Task3", 3000));


        await Task.WhenAll(tasks);
        stopwatch.Stop();
        Console.WriteLine($"Parallel execution time: {stopwatch.ElapsedMilliseconds}ms");
    }
}