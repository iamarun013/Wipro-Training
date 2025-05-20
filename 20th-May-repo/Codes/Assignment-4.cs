using System;

class LCSProgram
{
    // Function to find the length of the Longest Common Subsequence
    public static int LCS(string str1, string str2)
    {
        int m = str1.Length;
        int n = str2.Length;

        // Create DP table
        int[,] dp = new int[m + 1, n + 1];

        // Build the table in bottom-up fashion
        for (int i = 0; i <= m; i++)
        {
            for (int j = 0; j <= n; j++)
            {
                if (i == 0 || j == 0)
                {
                    dp[i, j] = 0;
                }
                else if (str1[i - 1] == str2[j - 1])
                {
                    dp[i, j] = dp[i - 1, j - 1] + 1;
                }
                else
                {
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                }
            }
        }

        // Optional: Uncomment below to print the DP table
        /*
        Console.WriteLine("DP Table:");
        for (int i = 0; i <= m; i++)
        {
            for (int j = 0; j <= n; j++)
            {
                Console.Write(dp[i, j] + " ");
            }
            Console.WriteLine();
        }
        */

        return dp[m, n];
    }

    // Function to reconstruct and print the LCS string
    public static string GetLCS(string str1, string str2)
    {
        int m = str1.Length;
        int n = str2.Length;
        int[,] dp = new int[m + 1, n + 1];

        // Fill the DP table
        for (int i = 0; i <= m; i++)
        {
            for (int j = 0; j <= n; j++)
            {
                if (i == 0 || j == 0)
                    dp[i, j] = 0;
                else if (str1[i - 1] == str2[j - 1])
                    dp[i, j] = dp[i - 1, j - 1] + 1;
                else
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
            }
        }

        // Reconstruct the LCS from the DP table
        int index = dp[m, n];
        char[] lcsChars = new char[index];
        int iIndex = m, jIndex = n;

        while (iIndex > 0 && jIndex > 0)
        {
            if (str1[iIndex - 1] == str2[jIndex - 1])
            {
                lcsChars[index - 1] = str1[iIndex - 1];
                iIndex--;
                jIndex--;
                index--;
            }
            else if (dp[iIndex - 1, jIndex] > dp[iIndex, jIndex - 1])
            {
                iIndex--;
            }
            else
            {
                jIndex--;
            }
        }

        return new string(lcsChars);
    }

    public static void Main()
    {
        string str1 = "AGGTAB";
        string str2 = "GXTXAYB";

        int length = LCS(str1, str2);
        Console.WriteLine($"Length of LCS: {length}");

        string lcs = GetLCS(str1, str2);
        Console.WriteLine($"LCS: {lcs}");
    }
}