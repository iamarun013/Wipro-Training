using System;

class Vehicle
{
    public string Make;
    public string Model;

    public void DisplayVehicle()
    {
        Console.WriteLine($"Vehicle Make: {Make}, Vehicle Model: {Model}");
    }
}

class Car : Vehicle
{
    public string FuelType;
    public string Color = "black"; // assuming color is black as per your message

    public void DisplayCar()
    {
        Console.WriteLine($"Car's colour is {Color}, fuel type: {FuelType}, Nissan GTR is a 4 seater Coupe with the last recorded price of Rs. 2.12 - 2.12 Crore. It is available in 2 variants, 3799 cc engine option and 1 transmission option: Automatic. Other key specifications of the GTR include a ground clearance (unladen) of...");
        // You can complete the sentence with actual data if needed
    }

    static void Main()
    {
        Car car1 = new Car();
        car1.Make = "2025";
        car1.Model = "Nissan GTR";
        car1.FuelType = "Premium Petrol";

        car1.DisplayVehicle();
        car1.DisplayCar();
    }
}