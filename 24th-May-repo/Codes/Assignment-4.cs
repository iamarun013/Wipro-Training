using System;
using System.Diagnostics;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        // List of files with their simulated download delays (in milliseconds)
        var files = new[]
        {
            ("File1.txt", 2000),
            ("File2.txt", 3000),
            ("File3.txt", 1500)
        };

        // Start the stopwatch to measure total download time
        Stopwatch stopwatch = Stopwatch.StartNew();

        // Create download tasks
        Task[] downloadTasks = new Task[files.Length];

        for (int i = 0; i < files.Length; i++)
        {
            var fileName = files[i].Item1;
            var delay = files[i].Item2;
            // Start downloading each file asynchronously
            downloadTasks[i] = DownloadFileAsync(fileName, delay);
        }

        // Await all downloads to complete
        await Task.WhenAll(downloadTasks);

        stopwatch.Stop();

        Console.WriteLine($"All files downloaded in {stopwatch.ElapsedMilliseconds} ms");
    }

    // Simulate downloading a file with a delay
    static async Task DownloadFileAsync(string fileName, int delay)
    {
        Console.WriteLine($"Starting download of {fileName}...");
        await Task.Delay(delay); // Simulate download time
        Console.WriteLine($"Completed download of {fileName}");
    }
}