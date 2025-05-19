using System;

interface IRemoteControl
{
    void IncreaseVolume();
    void DecreaseVolume();
}

abstract class SmartDevice
{
    public abstract void TurnOn();

    public void ShowStatus()
    {
        Console.WriteLine("Device Status: Active");
    }
}

class SmartLight : SmartDevice, IRemoteControl
{
    public override void TurnOn()
    {
        Console.WriteLine("Smart Light turned on");
    }

    public void IncreaseVolume()
    {
        Console.WriteLine("Lights do not support volume control");
    }

    public void DecreaseVolume()
    {
        Console.WriteLine("Lights do not support volume control");
    }
}

class SmartSpeaker : SmartDevice, IRemoteControl
{
    public override void TurnOn()
    {
        Console.WriteLine("Smart Speaker turned on");
    }

    public void IncreaseVolume()
    {
        Console.WriteLine("Speaker volume increased");
    }

    public void DecreaseVolume()
    {
        Console.WriteLine("Speaker volume decreased");
    }
}

class Program
{
    public static void Main()
    {
        IRemoteControl irc;

        // Using SmartLight
        irc = new SmartLight();
        SmartDevice device1 = new SmartLight();

        device1.TurnOn();
        device1.ShowStatus();
        irc.IncreaseVolume();
        irc.DecreaseVolume();

        Console.WriteLine();

        // Using SmartSpeaker
        irc = new SmartSpeaker();
        SmartDevice device2 = new SmartSpeaker();

        device2.TurnOn();
        device2.ShowStatus();
        irc.IncreaseVolume();
        irc.DecreaseVolume();
    }
}