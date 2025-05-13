using System;

abstract class PaymentGateway
{
    public abstract void ProcessPayment(double amount);

    public void ShowGatewayName()
    {
        Console.WriteLine("Processing Payment through gateway");
    }
}

class StripeGateway : PaymentGateway
{
    public override void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing Payment through Stripe: {amount}");
    }
}

class PayPalGateway : PaymentGateway
{
    public override void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing Payment through PayPal: {amount}");
    }
}

class Program
{
    public static void Main()
    {
        PaymentGateway pg;

        // Using Stripe Gateway
        pg = new StripeGateway();
        pg.ShowGatewayName();
        pg.ProcessPayment(2000.00);

        // Using PayPal Gateway
        pg = new PayPalGateway();
        pg.ShowGatewayName();
        pg.ProcessPayment(4500.00);
    }
}