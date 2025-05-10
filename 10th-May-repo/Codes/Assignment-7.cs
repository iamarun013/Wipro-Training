using System;

class Payment
{
    public decimal Amount { get; set; }
    public string Currency { get; set; }

    public void ProcessPayment()
    {
        Console.WriteLine($"The final payment details: {Amount} {Currency ?? "N/A"}");
    }

    public void ProcessPayment(decimal Amount)
    {
        this.Amount = Amount;
        Console.WriteLine($"The final payment details: {Amount} {Currency ?? "N/A"}");
    }

    public void ProcessPayment(decimal Amount, string Currency)
    {
        this.Amount = Amount;
        this.Currency = Currency;
        Console.WriteLine($"The final payment details: {Amount} {Currency}");
    }

    public void ProcessPayment(decimal Amount, string email)
    {
        // Note: This method only prints, does not set properties
        Console.WriteLine($"The final payment details: {Amount} with email {email}");
    }
}

class CreditCardPayment : Payment
{
    public int CardNumber { get; set; }
}

class PayPalPayment : Payment
{
    public string email { get; set; }
}

class Program
{
    public static void Main()
    {
        // Creating instances
        CreditCardPayment ccPayment = new CreditCardPayment();
        PayPalPayment ppPayment = new PayPalPayment();

        // Using CreditCardPayment
        ccPayment.Amount = 100m; // default currency is null
        ccPayment.ProcessPayment(); // prints 100 and null (or "N/A" if handled)

        ccPayment.Currency = "INR";
        ccPayment.ProcessPayment(); // prints 100 INR

        ccPayment.ProcessPayment(200m, "INR"); // sets Amount and Currency, prints 200 INR

        // Using PayPalPayment
        ppPayment.Amount = 200m; // default email is null
        ppPayment.ProcessPayment(); // prints 200 and null

        ppPayment.email = "abc12345@gmail.com";
        ppPayment.ProcessPayment(200m, "USD"); // prints 200 USD

        ppPayment.ProcessPayment(); // prints current Amount (200) and current Currency (null)

        // To make output clearer, you can initialize Currency to a default value
        // e.g., ppPayment.Currency = "USD"; before calling ProcessPayment()
    }
}