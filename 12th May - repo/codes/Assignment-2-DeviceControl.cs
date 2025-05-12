using System;

interface IDeviceControl
{
    void Turnon();
    void Turnoff();
}

class SmartTv : IDeviceControl
{
    public void Turnon()
    {
        Console.WriteLine("Smart Tv is ON.");
    }
    public void Turnoff()
    {
        Console.WriteLine("Smart Tv is OFF");
    }
}

class Speaker : IDeviceControl
{
    public void Turnon()
    {
        Console.WriteLine("Speaker is now turned on");
    }
    public void Turnoff()
    {
        Console.WriteLine("Speaker is now turned off");
    }
}

class Program
{
    static void Main()
    {
        IDeviceControl dc;

        dc = new SmartTv();
        dc.Turnon();
        dc.Turnoff();

        dc = new Speaker();
        dc.Turnon();
        dc.Turnoff();
    }
}