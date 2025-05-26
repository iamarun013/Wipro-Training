using System;
using System.Diagnostics;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        // Sequential execution
        var stopwatch = Stopwatch.StartNew();
        await SimulateWorkAsync("Work1", 1000);
        await SimulateWorkAsync("Work2", 2000);
        await SimulateWorkAsync("Work3", 1500);
        stopwatch.Stop();
        Console.WriteLine($"Sequential: {stopwatch.ElapsedMilliseconds} ms");

        // Parallel execution
        stopwatch.Restart();
        Task t1 = SimulateWorkAsync("Work1", 1000);
        Task t2 = SimulateWorkAsync("Work2", 2000);
        Task t3 = SimulateWorkAsync("Work3", 1500);
        await Task.WhenAll(t1, t2, t3);
        stopwatch.Stop();
        Console.WriteLine($"Parallel: {stopwatch.ElapsedMilliseconds} ms");
    }

    static async Task SimulateWorkAsync(string name, int delay)
    {
        await Task.Delay(delay);
    }
}