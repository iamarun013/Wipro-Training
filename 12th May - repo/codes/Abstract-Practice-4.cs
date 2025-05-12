using System;
//abstract class
abstract class Vehicle
{
    public string Brand;
    public int Year;
    // Concrete method
    public void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Year: {Year}");

    }
    // Abstract method
    public abstract void Start();
}

class Car : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("CAR IS STARTING WITH THE KEY");
            }

}

class Bike: Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Bike is starting with the kick");
    }
}