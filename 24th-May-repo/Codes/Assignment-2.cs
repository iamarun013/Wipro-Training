using System;
using System.Threading;

class Program{
    static void Main()
    {
        Thread thread1= new Thread(Task1);
        Thread thread2 = new Thread(Task2);
        Thread thread3 = new Thread(Task3);

        thread1.Start();
        thread2.Start();
        thread3.Start();

        thread1.Join();
        thread2.Join();
        thread3.Join();

          // After all threads have finished
        Console.WriteLine("All tasks done");
    }

    // Simulate a task: printing numbers from 1 to 5
    static void Task1()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Task1: {i}");
            Thread.Sleep(300); // Simulate work
        }
    }

    // Simulate a task: computing sum of first 100 numbers
    static void Task2()
    {
        int sum = 0;
        for (int i = 1; i <= 100; i++)
        {
            sum += i;
            Thread.Sleep(200); // Simulate work
        }
        Console.WriteLine($"Task2: Sum of 1 to 100 is {sum}");
    }

    // Simulate a waiting task
    static void Task3()
    {
        Console.WriteLine("Task3: Starting wait...");
        Thread.Sleep(2000); // Wait for 2 seconds
        Console.WriteLine("Task3: Done waiting");
    }
}
    
