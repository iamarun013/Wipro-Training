using System;

// Base class representing a generic Employee
class Employee
{
    /// <summary>
    /// Virtual method that can be overridden by derived classes
    /// to specify specific work behavior.
    /// </summary>
    public virtual void Work()
    {
        Console.WriteLine("Employee is working");
    }
}

// Derived class representing a Manager, which is a specialized Employee
class Manager : Employee
{
    /// <summary>
    /// Override of the Work method to specify Manager's behavior.
    /// </summary>
    public override void Work()
    {
        Console.WriteLine("Manager is supervising");
    }
}

class Program
{
    static void Main()
    {
        // Creating an instance of Employee
        Employee emp = new Employee();
        // Calling the Work method on Employee instance
        emp.Work();

        // Creating an instance of Manager
        Manager mgr = new Manager();
        // Calling the overridden Work method on Manager instance
        mgr.Work();

        // Demonstrating polymorphism:
        // A reference of type Employee pointing to a Manager object
        Employee polyEmp = new Manager();
        // Calling Work() on a base class reference that points to a derived class object
        // This will invoke the overridden method in Manager due to polymorphism
        polyEmp.Work();
    }
}