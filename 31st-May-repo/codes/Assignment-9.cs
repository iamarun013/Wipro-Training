using System;
using System.Diagnostics;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Starting weather fetch...");

        // Start stopwatch to measure total time
        Stopwatch stopwatch = Stopwatch.StartNew();

        // List of city names
        string[] cities = { "New York", "London", "Tokyo" };

        // Create tasks for fetching weather for each city
        Task<string>[] weatherTasks = new Task<string>[cities.Length];

        for (int i = 0; i < cities.Length; i++)
        {
            string city = cities[i];
            weatherTasks[i] = FetchWeatherAsync(city);
        }

        // Wait for all tasks to complete concurrently
        string[] results = await Task.WhenAll(weatherTasks);

        stopwatch.Stop();

        // Display results
        for (int i = 0; i < cities.Length; i++)
        {
            Console.WriteLine($"{cities[i]}: {results[i]}");
        }

        Console.WriteLine($"Total time taken: {stopwatch.ElapsedMilliseconds} ms");
    }

    static async Task<string> FetchWeatherAsync(string city)
    {
        // Simulate network delay (random between 1-3 seconds)
        Random rand = new Random();
        int delay = rand.Next(1000, 3000);
        await Task.Delay(delay);

        // Simulate weather data
        return $"Weather data for {city} (simulated, delay {delay} ms)";
    }
}