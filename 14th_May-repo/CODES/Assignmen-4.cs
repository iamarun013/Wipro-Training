using System;

abstract class FoodOrder
{
    public abstract void PlaceOrder(string item);

    public void OrderInfo()
    {
        Console.WriteLine("Placing food order");
    }
}

class FastFoodOrder : FoodOrder
{
    public override void PlaceOrder(string item)
    {
        Console.WriteLine($"Order placed for {item} at Fast Food Order");
    }
}

class FineDiningOrder : FoodOrder
{
    public override void PlaceOrder(string item)
    {
        Console.WriteLine($"Order placed for {item} at Fine Dining Restaurant");
    }
}

class Program
{
    public static void Main()
    {
        FoodOrder fo;

        fo = new FastFoodOrder();
        fo.PlaceOrder("Biriyani");

        fo = new FineDiningOrder();
        fo.PlaceOrder("Firni");
        fo.OrderInfo();
    }
}