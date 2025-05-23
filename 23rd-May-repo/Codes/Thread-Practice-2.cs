using System;
using System.Threading;

class Program
{
    static void PrintMessage(object message)
    {
        string msg = (string)message;//cast to correct type
        Console.WriteLine("Message: " + msg);
    }

    static void Main()
    {
        Thread myThread = new Thread(new ParameterizedThreadStart(PrintMessage));
        myThread.Start("Hello from the thread");
        }

    }