using System;
using System.Collections.Generic;

interface IRentable
{
    void Rent(int days);
}

public abstract class Vehicle : IRentable
{
    public string Model { get; set; }
    public decimal RentPerDay { get; set; }

    public Vehicle(string model, decimal rentPerDay)
    {
        this.Model = model;
        this.RentPerDay = rentPerDay;
    }

    public abstract void Rent(int days);

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Model: {Model} , Rent Per Day: {RentPerDay}");
    }
}

public class Car : Vehicle
{
    public Car(string model, decimal rentPerDay) : base(model, rentPerDay) { }

    public override void Rent(int days)
    {
        decimal cost = days * RentPerDay;
        Console.WriteLine($"Car '{Model}' rented for {days} days, total cost = Rs {cost}");
    }
}

public class Truck : Vehicle
{
    public Truck(string model, decimal rentPerDay) : base(model, rentPerDay) { }

    public override void Rent(int days)
    {
        decimal cost = days * RentPerDay;
        Console.WriteLine($"Truck '{Model}' rented for {days} days, cost = Rs {cost}");
    }
}

public class Bike : Vehicle
{
    public Bike(string model, decimal rentPerDay) : base(model, rentPerDay) { }

    public override void Rent(int days)
    {
        decimal cost = days * RentPerDay;
        Console.WriteLine($"Bike '{Model}' rented for {days} days, cost = Rs {cost}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car("Hyundai Verna", 1500),
            new Bike("Busa", 500),
            new Truck("Tata Ace", 2500)
        };

        Console.WriteLine("Available Vehicles:");
        for(int i=0; i<vehicles.Count; i++)
        {
            Console.Write($"{i+1}. ");
            vehicles[i].DisplayInfo();
        }

        Console.Write("\nHow many vehicles do you want to rent? ");
        int count = int.Parse(Console.ReadLine());

        for(int i=0; i< count; i++)
        {
            Console.WriteLine($"\nEnter vehicle number to rent (1-{vehicles.Count}):");
            int choice = int.Parse(Console.ReadLine()) - 1;

            if(choice >= 0 && choice < vehicles.Count)
            {
                Console.WriteLine("Enter number of days:");
                int days = int.Parse(Console.ReadLine());

                vehicles[choice].Rent(days);
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }

        Console.WriteLine("\nThank you for using the Vehicle Rental System");
    }
}