using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        var cts = new CancellationTokenSource();
        var task = DoWorkAsync(cts.Token);

        // Cancel after 2 seconds
        Task.Delay(2000).ContinueWith(_ => cts.Cancel());

        try
        {
            await task;
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Work was canceled.");
        }
    }

    static async Task DoWorkAsync(CancellationToken token)
    {
        int i = 0;
        while (true)
        {
            token.ThrowIfCancellationRequested();
            Console.WriteLine($"Working... {i++}");
            await Task.Delay(500);
        }
    }
}