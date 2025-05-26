using System;
using System.Diagnostics;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        // Start measuring total download time
        Stopwatch stopwatch = Stopwatch.StartNew();

        // Start downloading three files in parallel
        Task download1 = DownloadFileAsync("File1.txt", 2000);
        Task download2 = DownloadFileAsync("File2.txt", 3000);
        Task download3 = DownloadFileAsync("File3.txt", 1500);

        // Await all downloads to complete
        await Task.WhenAll(download1, download2, download3);

        stopwatch.Stop();
        Console.WriteLine($"Total download time: {stopwatch.ElapsedMilliseconds} ms");
    }

    static async Task DownloadFileAsync(string fileName, int delay)
    {
        Console.WriteLine($"Starting download of {fileName}...");
        await Task.Delay(delay); // Simulate download delay
        Console.WriteLine($"{fileName} downloaded in {delay} ms");
    }
}