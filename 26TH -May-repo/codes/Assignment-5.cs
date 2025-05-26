using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        // Define cities
        string[] cities = { "New York", "London", "Tokyo" };

        // Call GetTemperatureAsync for each city
        foreach (var city in cities)
        {
            int temperature = await GetTemperatureAsync(city);
            Console.WriteLine($"The temperature in {city} is {temperature}°C");
        }
    }

    static async Task<int> GetTemperatureAsync(string city)
    {
        // Simulate an async operation with a delay
        await Task.Delay(1000);
        // Generate a random temperature
        Random rand = new Random();
        int temp = rand.Next(-10, 35); // Random temp between -10 and 34
        return temp;
    }
}