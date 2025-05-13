using System;

interface IOrder
{
    void PlaceOrder(string item);
    void CancelOrder(string item);
}

class DineInOrder : IOrder
{
    public void PlaceOrder(string item)
    {
        Console.WriteLine(item);
    }

    public void CancelOrder(string item)
    {
        Console.WriteLine(item);
    }
}

class TakeAwayOrder : IOrder
{
    public void PlaceOrder(string item)
    {
        Console.WriteLine(item);
    }
    public void CancelOrder(string item)
    {
        Console.WriteLine(item);
    }
}

class Program
{
    public static void Main()
    {
        IOrder order;

        // Dine-in order
        order = new DineInOrder();
        order.PlaceOrder("Place dine-in order for item");
        order.CancelOrder("Cancel dine-in order for item");

        // Take-away order
        order = new TakeAwayOrder();
        order.PlaceOrder("Place takeaway order for item");
        order.CancelOrder("Cancel taking-away order for item");
    }
}