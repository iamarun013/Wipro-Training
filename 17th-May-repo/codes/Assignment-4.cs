using System;

abstract class Animal
{
    public abstract void MakeSound();

    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog is barking");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat is Meowing");
    }
}

class Program
{
    public static void Main()
    {
        // Declare an Animal variable
        Animal animal = new Dog();

        // Call methods on the animal instance
        animal.MakeSound(); // Dog's sound
        animal.Eat();

        // Reassign to a Cat
        animal = new Cat();
        animal.MakeSound(); // Cat's sound
        animal.Eat();
    }
}