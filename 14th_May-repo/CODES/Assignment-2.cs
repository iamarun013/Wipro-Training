using System;

interface IBankAccount
{
    void Deposit(double amount);
    void Withdraw(double amount);
    void CheckBalance();
}

class SavingsAccount : IBankAccount
{
    private double balance = 0;

    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine($"Deposited {amount}. New balance: {balance}");
    }

    public void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn {amount}. Remaining balance: {balance}");
        }
        else
        {
            Console.WriteLine("Insufficient funds");
        }
    }

    public void CheckBalance()
    {
        Console.WriteLine($"Savings Account Balance: {balance}");
    }
}

class CurrentAccount : IBankAccount
{
    private double balance = 0;

    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine($"Deposited {amount}. New balance: {balance}");
    }

    public void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn {amount}. Remaining balance: {balance}");
        }
        else
        {
            Console.WriteLine("Insufficient funds");
        }
    }

    public void CheckBalance()
    {
        Console.WriteLine($"Current Account Balance: {balance}");
    }
}

class Program
{
    public static void Main()
    {
        IBankAccount ba;

        ba = new SavingsAccount();
        ba.Deposit(30000);
        ba.Withdraw(10000);
        ba.CheckBalance();

        ba = new CurrentAccount();
        ba.Deposit(5000);
        ba.Withdraw(2000);
        ba.CheckBalance();
    }
}