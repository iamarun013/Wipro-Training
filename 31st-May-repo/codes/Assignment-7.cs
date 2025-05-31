using System;

namespace CalculatorApp
{
    class Calculator
    {
        // Add methods
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static float Add(float a, float b)
        {
            return a + b;
        }

        public static double Add(double a, double b)
        {
            return a + b;
        }

        // Subtract methods
        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static float Subtract(float a, float b)
        {
            return a - b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        // Multiply methods
        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static float Multiply(float a, float b)
        {
            return a * b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator with Method Overloading");
            bool continueCalculation = true;

            while (continueCalculation)
            {
                Console.WriteLine("\nSelect operation:");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice (1-4): ");
                int choice;

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
                    continue;
                }

                if (choice == 4)
                {
                    continueCalculation = false;
                    Console.WriteLine("Exiting the calculator. Goodbye!");
                    break;
                }

                Console.WriteLine("Enter first number:");
                string input1 = Console.ReadLine();

                Console.WriteLine("Enter second number:");
                string input2 = Console.ReadLine();

                // Determine data type based on user input
                if (int.TryParse(input1, out int int1) && int.TryParse(input2, out int int2))
                {
                    // Call integer method
                    PerformOperation(choice, int1, int2);
                }
                else if (float.TryParse(input1, out float float1) && float.TryParse(input2, out float float2))
                {
                    // Call float method
                    PerformOperation(choice, float1, float2);
                }
                else if (double.TryParse(input1, out double double1) && double.TryParse(input2, out double double2))
                {
                    // Call double method
                    PerformOperation(choice, double1, double2);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter numeric values.");
                }
            }
        }

        static void PerformOperation(int choice, int a, int b)
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Result: {Calculator.Add(a, b)}");
                    break;
                case 2:
                    Console.WriteLine($"Result: {Calculator.Subtract(a, b)}");
                    break;
                case 3:
                    Console.WriteLine($"Result: {Calculator.Multiply(a, b)}");
                    break;
            }
        }

        static void PerformOperation(int choice, float a, float b)
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Result: {Calculator.Add(a, b)}");
                    break;
                case 2:
                    Console.WriteLine($"Result: {Calculator.Subtract(a, b)}");
                    break;
                case 3:
                    Console.WriteLine($"Result: {Calculator.Multiply(a, b)}");
                    break;
            }
        }

        static void PerformOperation(int choice, double a, double b)
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Result: {Calculator.Add(a, b)}");
                    break;
                case 2:
                    Console.WriteLine($"Result: {Calculator.Subtract(a, b)}");
                    break;
                case 3:
                    Console.WriteLine($"Result: {Calculator.Multiply(a, b)}");
                    break;
            }
        }
    }
}