using System;
using System.Collections.Generic;

// Interface defining payment processing
public interface IPaymentProcessor
{
    void ProcessPayment(decimal amount);
}

// Abstract base class for payment gateways
public abstract class PaymentGateway : IPaymentProcessor
{
    public string GatewayName { get; protected set; }

    public PaymentGateway(string name)
    {
        GatewayName = name;
    }

    // Common validation method for all gateways
    public virtual void Validate()
    {
        Console.WriteLine($"Validating {GatewayName} payment gateway...");
        // Add common validation logic if needed
    }

    // Abstract method to process payment, implemented by subclasses
    public abstract void ProcessPayment(decimal amount);
}

// Razorpay class
public class Razorpay : PaymentGateway
{
    public Razorpay() : base("Razorpay") { }

    public override void ProcessPayment(decimal amount)
    {
        Validate();
        Console.WriteLine($"Processing Razorpay payment of {amount:C}");
        // Add Razorpay-specific processing logic here
    }
}

// PayPal class
public class PayPal : PaymentGateway
{
    public PayPal() : base("PayPal") { }

    public override void ProcessPayment(decimal amount)
    {
        Validate();
        Console.WriteLine($"Processing PayPal payment of {amount:C}");
        // Add PayPal-specific processing logic here
    }
}

// Stripe class
public class Stripe : PaymentGateway
{
    public Stripe() : base("Stripe") { }

    public override void ProcessPayment(decimal amount)
    {
        Validate();
        Console.WriteLine($"Processing Stripe payment of {amount:C}");
        // Add Stripe-specific processing logic here
    }
}

// Main program
class Program
{
    static void Main()
    {
        // Create a list of payment processors
        List<IPaymentProcessor> payments = new List<IPaymentProcessor>
        {
            new Razorpay(),
            new PayPal(),
            new Stripe()
        };

        // Define amounts for each payment
        decimal[] amounts = { 100.00m, 250.50m, 75.25m };

        // Process payments polymorphically
        for (int i = 0; i < payments.Count; i++)
        {
            payments[i].ProcessPayment(amounts[i]);
            Console.WriteLine(); // For better readability
        }
    }
}