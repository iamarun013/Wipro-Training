using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task DoWorkAsync(CancellationToken token)
    {
        Console.WriteLine("Work started. Press Ctrl+C to cancel or wait for 10 seconds...");
        try
        {
            for (int i = 1; i <= 10; i++)
            {
                // Simulate work
                await Task.Delay(1000, token);
                Console.WriteLine($"Progress: {i * 10}%");
            }
            Console.WriteLine("Work completed successfully.");
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Work was canceled.");
        }
    }

    static async Task Main()
    {
        using (var cts = new CancellationTokenSource())
        {
            // Start the task
            var task = DoWorkAsync(cts.Token);

            // Cancel after 2 seconds
            await Task.Delay(2000);
            cts.Cancel();

            try
            {
                await task;
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Main caught cancellation exception.");
            }
        }
        Console.WriteLine("Program ended.");
    }
}