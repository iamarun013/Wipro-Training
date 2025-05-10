using System;

class Program
{
    /// <summary>
    /// Calculates the power of an integer base raised to an integer exponent.
    /// </summary>
    /// <param name="base">The base number.</param>
    /// <param name="exponent">The exponent.</param>
    /// <returns>The result of base raised to the power of exponent.</returns>
    public int Power(int baseNumber, int exponent)
    {
        // Using Math.Pow and casting the result back to int
        return (int)Math.Pow(baseNumber, exponent);
    }

    /// <summary>
    /// Calculates the power of a double base raised to a double exponent.
    /// </summary>
    /// <param name="base">The base number.</param>
    /// <param name="exponent">The exponent.</param>
    /// <returns>The result of base raised to the power of exponent.</returns>
    public double Power(double baseNumber, double exponent)
    {
        return Math.Pow(baseNumber, exponent);
    }

    /// <summary>
    /// Main method - program entry point.
    /// </summary>
    public static void Main()
    {
        Program p = new Program();

        Console.WriteLine("Power of a number is calculated:");
        Console.WriteLine(p.Power(2, 6)); // 2^6 = 64
        Console.WriteLine(p.Power(3.0, 8.0)); // 3^8 = 6561
    }
}

