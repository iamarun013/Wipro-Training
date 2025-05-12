using System;

interface IPayment
{
    void ProcessPayment(decimal amount);
}

//Implememnting the interface in Credit Card Payment
class CreditCardPayment : IPayment
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing credit card payment of {amount}");

    }
}

class PayPalPayment : IPayment
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing Paypal payment of {amount}");

    }
}

class Program{
    static void Main()
    {
        // using interface as a reference
        IPayment payment;

        //credit card payment
        payment= new CreditCardPayment();
        payment.ProcessPayment(1500.50m);

        //Paypal amount
        payment = new PayPalPayment();
        payment.ProcessPayment(2500.75m);
    }
}

