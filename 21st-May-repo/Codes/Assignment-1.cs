using System;

class TowerOfHanoi
{
    // Recursive method to solve Tower of Hanoi
    static void SolveHanoi(int n, string source, string auxiliary, string destination)
    {
        if (n == 1)
        {
            Console.WriteLine($"Move disk 1 from {source} to {destination}");
            return;
        }

        // Move n-1 disks from source to auxiliary
        SolveHanoi(n - 1, source, destination, auxiliary);

        // Move the nth disk from source to destination
        Console.WriteLine($"Move disk {n} from {source} to {destination}");

        // Move n-1 disks from auxiliary to destination
        SolveHanoi(n - 1, auxiliary, source, destination);
    }

    static void Main()
    {
        int numberOfDisks = 3; // Change this value as needed
        Console.WriteLine($"Solution for Tower of Hanoi with {numberOfDisks} disks:");
        SolveHanoi(numberOfDisks, "Source", "Auxiliary", "Destination");
    }
}