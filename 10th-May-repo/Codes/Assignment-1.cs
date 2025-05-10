using System;

// Base class representing a generic appliance
class Appliance
{
    /// <summary>
    /// Virtual method to operate the appliance.
    /// Can be overridden by derived classes to specify specific operation behavior.
    /// </summary>
    public virtual void Operate()
    {
        Console.WriteLine("Washing Clothes");
    }
}

// Derived class representing a Washing Machine, inheriting from Appliance
class WashingMachine : Appliance
{
    /// <summary>
    /// Override of the Operate method to specify washing machine operation.
    /// </summary>
    public override void Operate()
    {
        Console.WriteLine("Washing Clothes in the washing machine");
    }

    static void Main()
    {
        // Create an Appliance reference pointing to a WashingMachine object
        Appliance obj1 = new WashingMachine();

        // Call the Operate method
        // Due to polymorphism, the overridden method in WashingMachine is invoked
        obj1.Operate();
    }
}