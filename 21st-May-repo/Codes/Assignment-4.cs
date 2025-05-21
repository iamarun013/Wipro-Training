using System;
using System.Collections.Generic;

class NQueens
{
    // Store the positions of the queens
    private int[] positions;
    private int size;
    private List<int[]> solutions;

    public NQueens(int n)
    {
        size = n;
        positions = new int[n]; // positions[i] = column of queen in row i
        solutions = new List<int[]>();
    }

    public void Solve()
    {
        PlaceQueen(0);
        PrintSolutions();
    }

    private void PlaceQueen(int row)
    {
        if (row == size)
        {
            // Found a valid solution, store a copy
            int[] solution = new int[size];
            Array.Copy(positions, solution, size);
            solutions.Add(solution);
            return;
        }

        for (int col = 0; col < size; col++)
        {
            if (IsSafe(row, col))
            {
                positions[row] = col;
                PlaceQueen(row + 1);
                // Backtrack: no need to unset positions, will overwrite
            }
        }
    }

    private bool IsSafe(int row, int col)
    {
        for (int i = 0; i < row; i++)
        {
            // Check same column or diagonals
            if (positions[i] == col || Math.Abs(positions[i] - col) == Math.Abs(i - row))
                return false;
        }
        return true;
    }

    private void PrintSolutions()
    {
        Console.WriteLine($"Total solutions: {solutions.Count}");
        int count = 1;
        foreach (var solution in solutions)
        {
            Console.WriteLine($"Solution {count++}:");
            PrintBoard(solution);
            Console.WriteLine();
        }
    }

    private void PrintBoard(int[] solution)
    {
        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                if (solution[row] == col)
                    Console.Write("Q ");
                else
                    Console.Write(". ");
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        int n = 8; // Change N here
        NQueens solver = new NQueens(n);
        solver.Solve();
    }
}