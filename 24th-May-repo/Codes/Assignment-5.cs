using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        // Cities to fetch temperatures for
        string[] cities = { "New York", "London", "Tokyo" };

        // Create tasks for each city
        Task<int> task1 = GetTemperatureAsync(cities[0]);
        Task<int> task2 = GetTemperatureAsync(cities[1]);
        Task<int> task3 = GetTemperatureAsync(cities[2]);

        // Await all tasks to complete and get results
        int[] temperatures = await Task.WhenAll(task1, task2, task3);

        // Print results
        for (int i = 0; i < cities.Length; i++)
        {
            Console.WriteLine($"Temperature in {cities[i]}: {temperatures[i]}°C");
        }
    }

    // Simulate fetching temperature with a delay and return a random value
    static async Task<int> GetTemperatureAsync(string city)
    {
        Console.WriteLine($"Fetching temperature for {city}...");
        await Task.Delay(1000); // Simulate network delay

        // Generate a random temperature between -10 and 40
        Random rand = new Random();
        int temp = rand.Next(-10, 41);
        return temp;
    }
}