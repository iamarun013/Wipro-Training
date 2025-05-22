using System;
using System.Collections.Generic;

// 1. Abstract base class Vehicle
public abstract class Vehicle
{
    public string VehicleNumber { get; set; }
    public string Brand { get; set; }
    public decimal RatePerDay { get; set; }

    // Virtual method to calculate rent
    public virtual decimal CalculateRent(int days)
    {
        return RatePerDay * days;
    }
}

// 2. Derived class Car
public class Car : Vehicle
{
    public override decimal CalculateRent(int days)
    {
        // Example logic: base rate + 10% surcharge
        decimal baseRent = base.CalculateRent(days);
        decimal surcharge = 0.10m * baseRent;
        return baseRent + surcharge;
    }
}

// 2. Derived class Bike
public class Bike : Vehicle
{
    public override decimal CalculateRent(int days)
    {
        // Example logic: base rate + flat surcharge of $5 per day
        decimal baseRent = base.CalculateRent(days);
        decimal surcharge = 5m * days;
        return baseRent + surcharge;
    }
}

// 2. Derived class Truck
public class Truck : Vehicle
{
    public override decimal CalculateRent(int days)
    {
        // Example logic: base rate + 20% surcharge
        decimal baseRent = base.CalculateRent(days);
        decimal surcharge = 0.20m * baseRent;
        return baseRent + surcharge;
    }
}

class Program
{
    static void Main()
    {
        // 3. Create a list of Vehicle objects
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car { VehicleNumber = "C001", Brand = "Toyota", RatePerDay = 50 },
            new Bike { VehicleNumber = "B001", Brand = "Yamaha", RatePerDay = 20 },
            new Truck { VehicleNumber = "T001", Brand = "Volvo", RatePerDay = 80 }
        };

        int rentalDays = 5;

        // Display rent for each vehicle using polymorphism
        foreach (var vehicle in vehicles)
        {
            decimal rent = vehicle.CalculateRent(rentalDays);
            Console.WriteLine($"Vehicle {vehicle.VehicleNumber} ({vehicle.Brand}) rent for {rentalDays} days: {rent:C}");
        }
    }
}