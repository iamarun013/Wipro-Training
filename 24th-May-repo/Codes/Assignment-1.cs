using System;
using System.Threading;

class Program{
    static volatile bool pause = false;
    static volatile bool stop = false;

    static void PrimeNumbers()
    {
        int number = 1;
        Thread currntThread = Thread.CurrentThread;
        while(number<=100)
        {
            if(stop)
            {
                Console.WriteLine($"Thread is stopping: Final number:{number-1}");
                break;
            }
            if(pause)
            {
                Console.WriteLine("Thread Paused...");
                while(pause && !stop)
                {
                    CurrntThread.Sleep(200);
                }
                Console.WriteLine("Thread resumed");
            }
            Console.WriteLine($"Number: { number}");
            number++;
            CurrntThread.Sleep(100); //Simulate Work
        }
        Console.WriteLine($"Thread ending... State:{currntThread.ThreadState}");
    }

    public static void Main()
    {
        Thread thread= new Thread(new ThreadStart(PrimeNumbers));
        thread.Start();

        thread.Sleep(1500);
        Console.WriteLine("Main: Pausing thread...");
        pause =true;
        Console.WriteLine($"Main: Thread state after pause:{thread.ThreadState}");
        thread.Sleep(1000);
        Console.WriteLine("Main: Resuming Thread...");
        pause = false;

        thread.Sleep(1500);
        Console.WriteLine("Main: Stopping thread....");
        stop = true;
        thread.Join();

        Console.WriteLine($"Main: Thread has terminated. Final ThreadState:{thread.ThreadState}");
    }

}