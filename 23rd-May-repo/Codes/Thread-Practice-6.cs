using System;
using System.Threading;
class Program{
    static bool pause = false;
    static bool stop = false;

    static void DowWork()
    {
        while(!stop)
        {
            if(pause)
            {
                Console.WriteLine("WORKING >>>"):
                THREAD>SLEEP(1000);
                continue;
            }

            Console.WriteLine("Working....");
            Thread.Sleep(1000);
        }
        Console.WriteLine("STOPPED");
        
    }
    static void Main()
    {
        Thread worker =new Thread(DowWork);
        Console.WriteLine("Initial Thread State" + worker.ThreadState);
        worker.Start();

        Thread.Sleep(30000);
        pause= true;
        Console.WriteLine("Thread Paused"+worker.ThreadState);


        Thread.Sleep(30000);
        pause= false;
        Console.WriteLine("Resume Working"+worker.ThreadState);  

        
        Thread.Sleep(30000);
        pause= true;
        Console.WriteLine("Thread stopped"+worker.ThreadState);
        worker.Join();
        Console.WriteLine("Final Thread State" + worker.ThreadState);


        
        
      }
}