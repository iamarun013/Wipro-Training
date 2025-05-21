using System;
using System.Collections.Generic;

class CoinChangeGreedy
{
    // Function to find minimum number of coins using greedy approach
    public static int MinCoins(int amount, int[] coins)
    {
        int count = 0;
        int remainingAmount = amount;

        foreach (int coin in coins)
        {
            // Use as many coins of the current denomination as possible
            while (remainingAmount >= coin)
            {
                remainingAmount -= coin;
                count++;
            }
        }

        // If remainingAmount is not zero, no solution with given denominations
        if (remainingAmount != 0)
        {
            Console.WriteLine("Cannot make the exact amount with the given denominations.");
            return -1;
        }

        return count;
    }

    static void Main()
    {
        // Example coin denominations (must be sorted in descending order for greedy)
        int[] coins = { 25, 10, 5, 1 };
        int amount = 87;

        int minCoins = MinCoins(amount, coins);
        if (minCoins != -1)
        {
            Console.WriteLine($"Minimum coins required to make {amount} is {minCoins}.");
        }
        else
        {
            Console.WriteLine("Change cannot be made with the given denominations.");
        }
    }
}