using System;

class SmartDevice
{
    public string DeviceName;
    public bool PowerStatus;

    public void TogglePower()
    {
        PowerStatus = !PowerStatus; // Toggle the current power status
    }
}

class SmartLight : SmartDevice
{
    public int Brightness;

    public void ChangeBrightness()
    {
        Console.WriteLine("Enter the brightness level:");
        Brightness = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Brightness set to {Brightness}");
    }
}

class SmartThermostat : SmartDevice
{
    public double Temperature;

    public void ChangeTemp()
    {
        Console.WriteLine("Enter your preferred temperature:");
        Temperature = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Temperature set to {Temperature}");
    }
}

class Program
{
    public static void Main()
    {
        SmartDevice device1 = new SmartDevice();
        SmartLight light = new SmartLight();
        SmartThermostat thermostat = new SmartThermostat();

        // Set initial PowerStatus
        Console.WriteLine("Enter device power status (true/false):");
        bool powerInput;
        if (Boolean.TryParse(Console.ReadLine(), out powerInput))
        {
            device1.PowerStatus = powerInput;
        }
        else
        {
            Console.WriteLine("Invalid input, defaulting to false.");
            device1.PowerStatus = false;
        }

        // Toggle power
        device1.TogglePower();
        Console.WriteLine($"Device power status is now: {device1.PowerStatus}");

        // Use SmartLight
        light.DeviceName = "Living Room Light";
        Console.WriteLine($"Is {light.DeviceName} ON? {light.PowerStatus}");
        Console.WriteLine("Toggling light power...");
        light.TogglePower();
        Console.WriteLine($"{light.DeviceName} power status: {light.PowerStatus}");
        light.ChangeBrightness();

        // Use SmartThermostat
        thermostat.DeviceName = "Main Thermostat";
        Console.WriteLine($"Current temperature: {thermostat.Temperature}");
        thermostat.ChangeTemp();
    }
}