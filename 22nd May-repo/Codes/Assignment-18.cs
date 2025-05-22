using System;
using System.Collections.Generic;

// 1. Abstract Animal class
public abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public abstract void MakeSound();

    public void Feed()
    {
        Console.WriteLine($"Feeding {Name} the {GetType().Name}");
    }
}

// 2. Derived classes: Lion and Elephant
public class Lion : Animal
{
    public Lion(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the Lion roars!");
    }
}

public class Elephant : Animal
{
    public Elephant(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the Elephant trumpets!");
    }
}

// 3. Monkey class
public class Monkey : Animal
{
    public Monkey(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the Monkey chatters!");
    }
}

// Zoo class managing a list of animals
public class Zoo
{
    private List<Animal> animals = new List<Animal>();

    public void AddAnimal(Animal animal)
    {
        animals.Add(animal);
    }

    public void PerformActions()
    {
        foreach (var animal in animals)
        {
            animal.MakeSound();
            animal.Feed();
            Console.WriteLine(); // for spacing
        }
    }
}

class Program
{
    static void Main()
    {
        // Create zoo
        Zoo zoo = new Zoo();

        // Add animals
        zoo.AddAnimal(new Lion("Leo", 5));
        zoo.AddAnimal(new Elephant("Dumbo", 10));
        zoo.AddAnimal(new Monkey("George", 3));

        // Invoke actions
        zoo.PerformActions();
    }
}