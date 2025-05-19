using System;

// Step 1: Abstract class PaymentMethod
public abstract class PaymentMethod
{
    public abstract void ProcessPayment(decimal amount);

    public void ShowPaymentMethod()
    {
        Console.WriteLine("Payment Method: " + this.GetType().Name);
    }
}

// Step 2: Derived class for Credit Card Payment
public class CreditCardPayment : PaymentMethod
{
    public override void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing credit card payment of ₹{amount}");
    }
}

// Derived class for UPI Payment
public class UPIPayment : PaymentMethod
{
    public override void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing UPI payment of ₹{amount}");
    }
}

class Program
{
    static void Main()
    {
        // Create objects using base class reference
        PaymentMethod creditCard = new CreditCardPayment();
        PaymentMethod upi = new UPIPayment();

        // Call ShowPaymentMethod() and ProcessPayment() for credit card
        creditCard.ShowPaymentMethod();
        creditCard.ProcessPayment(1500m);

        Console.WriteLine(); // For spacing

        // Call ShowPaymentMethod() and ProcessPayment() for UPI
        upi.ShowPaymentMethod();
        upi.ProcessPayment(2500m);
    }
}