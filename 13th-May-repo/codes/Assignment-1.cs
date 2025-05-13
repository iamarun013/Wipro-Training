using System;

interface ITransport
{
    void Start();
    void Stop();
}

class Bus : ITransport
{
    public void Start()
    {
        Console.WriteLine("Bus is starting");
    }
    public void Stop()
    {
        Console.WriteLine("Bus is stopping");
    }
}

class Train : ITransport
{
    public void Start()
    {
        Console.WriteLine("Train is starting");
    }

    public void Stop()
    {
        Console.WriteLine("Train is stopping");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        ITransport transport;

        // Create and use Bus
        transport = new Bus();
        transport.Start();
        transport.Stop();

        // Create and use Train
        transport = new Train();
        transport.Start();
        transport.Stop();
    }
}