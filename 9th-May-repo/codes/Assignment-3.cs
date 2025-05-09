using System;

// Base class representing a generic shape
class Shape
{
    /// <summary>
    /// Virtual method to draw a shape.
    /// Can be overridden by derived classes to specify specific shapes.
    /// </summary>
    public virtual void Draw()
    {
        Console.WriteLine("Draw a Shape");
    }
}

// Derived class representing a Circle, inheriting from Shape
class Circle : Shape
{
    /// <summary>
    /// Override of the Draw method to draw a circle.
    /// </summary>
    public override void Draw()
    {
        Console.WriteLine("Draw a Circle");
    }

    static void Main()
    {
        // Create a Shape reference pointing to a Circle object
        Shape obj1 = new Circle();

        // Call the Draw method
        // Due to polymorphism, the overridden method in Circle is invoked
        obj1.Draw();
    }
}