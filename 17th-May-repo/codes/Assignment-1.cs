using System;
interface Imaintanance
{
    void Service();
    void Repair();
}

class CarMaintanance:Imaintanance
{
    public void Service()
    {
        Console.WriteLine("Car is being Served");
    }

    public void Repair()
    {
        Console.WriteLine("Car is being repaired");
    }
}

class BikeMaintanance:Imaintanance
{
    public void Service()
    {
        Console.WriteLine("Bike is being Served");
    }

    public void Repair()
    {
        Console.WriteLine("Bike is being repaired");
    }
}

class Program{
    public static void Main()
    {
        Imaintanance obj1=new CarMaintanance();
        obj1.Service();
        obj1.Repair();

        Imaintanance obj2 = new BikeMaintanance();
        obj2.Service();
        obj2.Repair();
    }
}