using System;

interface ICalculator
{
    void Add(int a, int b);
    void Subtract(int a, int b);
    void Multiply(int a, int b);
    void Divide(int a, int b);
}

class SimpleCalculator : ICalculator
{
    public void Add(int a, int b)
    {
        Console.WriteLine($"Addition result is = {a + b}");
    }

    public void Subtract(int a, int b)
    {
        Console.WriteLine($"Subtraction result is = {a - b}");
    }

    public void Multiply(int a, int b)
    {
        Console.WriteLine($"Multiplication result is = {a * b}");
    }

    public void Divide(int a, int b)
    {
        if (b != 0)
            Console.WriteLine($"Division result is = {(double)a / b}");
        else
            Console.WriteLine("Wrong inputs or bad divisor");
    }

    public static void Main()
    {
        ICalculator calc = new SimpleCalculator();

        calc.Add(2, 4);
        calc.Subtract(5, 2);
        calc.Multiply(2, 3);
        calc.Divide(19, 0); // handle division by zero
    }
}