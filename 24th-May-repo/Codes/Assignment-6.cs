using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        // Create three tasks with different delays
        Task task1 = Task.Delay(3000).ContinueWith(_ => "Task 1");
        Task task2 = Task.Delay(2000).ContinueWith(_ => "Task 2");
        Task task3 = Task.Delay(1000).ContinueWith(_ => "Task 3");

        Task<string> firstCompletedTask = await Task.WhenAny(task1, task2, task3) as Task<string>;

        string completedTaskName = await firstCompletedTask;

        Console.WriteLine($"{completedTaskName} completed first.");
    }
}