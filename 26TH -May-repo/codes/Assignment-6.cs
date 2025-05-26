using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        // Create three tasks with different delays
        Task task1 = DelayTaskAsync("Task1", 3000);
        Task task2 = DelayTaskAsync("Task2", 1000);
        Task task3 = DelayTaskAsync("Task3", 2000);

        // Wait for any of the tasks to complete
        Task firstCompleted = await Task.WhenAny(task1, task2, task3);

        // Determine which task finished first
        if (firstCompleted == task1)
        {
            Console.WriteLine("First completed: Task1");
        }
        else if (firstCompleted == task2)
        {
            Console.WriteLine("First completed: Task2");
        }
        else if (firstCompleted == task3)
        {
            Console.WriteLine("First completed: Task3");
        }
    }

    static async Task DelayTaskAsync(string name, int delayMilliseconds)
    {
        await Task.Delay(delayMilliseconds);
        Console.WriteLine($"{name} finished after {delayMilliseconds} ms");
    }
}
