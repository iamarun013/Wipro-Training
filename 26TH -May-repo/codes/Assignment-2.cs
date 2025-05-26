using System;
using System.Threading;

class Program
{
    static void Main()
    {
        // Create three threads with different tasks
        Thread thread1 = new Thread(Task1);
        Thread thread2 = new Thread(Task2);
        Thread thread3 = new Thread(Task3);

        // Start all threads
        thread1.Start();
        thread2.Start();
        thread3.Start();

        // Wait for all threads to complete
        thread1.Join();
        thread2.Join();
        thread3.Join();

        // After all threads are done
        Console.WriteLine("All tasks done");
    }

    static void Task1()
    {
        Console.WriteLine("Task 1: Printing numbers from 1 to 5");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Task 1: {i}");
            Thread.Sleep(200); // Simulate work
        }
    }

    static void Task2()
    {
        Console.WriteLine("Task 2: Computing sum from 1 to 100");
        int sum = 0;
        for (int i = 1; i <= 100; i++)
        {
            sum += i;
        }
        Console.WriteLine($"Task 2: Sum = {sum}");
        Thread.Sleep(300); // Simulate work
    }

    static void Task3()
    {
        Console.WriteLine("Task 3: Waiting for 1 second");
        Thread.Sleep(1000); // Simulate waiting
        Console.WriteLine("Task 3: Done waiting");
    }
}