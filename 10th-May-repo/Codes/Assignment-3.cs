using System;

class Program
{
    /// <summary>
    /// Calculates the area of a rectangle.
    /// </summary>
    public static int Area(int length, int breadth)
    {
        return length * breadth;
    }

    /// <summary>
    /// Calculates the area of a circle.
    /// </summary>
    public static double Area(double radius)
    {
        return 3.14 * radius * radius;
    }

    /// <summary>
    /// Calculates the area of a triangle.
    /// </summary>
    public static double Area(int baseLength, int height)
    {
        return (baseLength * height) / 2.0;
    }

    public static void Main()
    {
        Console.WriteLine("Area of Rectangle, circle, and triangle are as follows:");
        Console.WriteLine("Rectangle: " + Area(4, 6));
        Console.WriteLine("Circle: " + Area(3));
        Console.WriteLine("Triangle: " + Area(2, 4));
    }
}