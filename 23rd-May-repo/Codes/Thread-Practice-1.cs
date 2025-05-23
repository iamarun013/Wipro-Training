using System;
using System.Threading;

class Program
{
    static void PrintNumbers()
    {
        for (int i = 1; i <= 10; i++) {
            Console.WriteLine($"Thread: {i}");
            Thread.Sleep(1000);//pause for 0.5s
        }
    }

    static void Main()
    {
        Thread myThread = new Thread(PrintNumbers);
        myThread.Start();
        for (int i = 1; i <= 10; i++) {
            Console.WriteLine($"Main: {i}");
            Thread.Sleep(500);
        }

    }
}