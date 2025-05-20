using System;

public static int LinearSearch(int[] arr, int n)
{
    for (int i = 0; i < arr.Length; i++) // corrected to include the last element
    {
        if (arr[i] == n)
            return i;
    }
    return -1; // not found
}

public static int BinarySearch(int[] arr, int n)
{
    int left = 0;
    int right = arr.Length - 1;

    while (left <= right)
    {
        int mid = (left + right) / 2;
        if (arr[mid] == n)
        {
            return mid;
        }
        else if (arr[mid] < n)
        {
            left = mid + 1;
        }
        else
        {
            right = mid - 1;
        }
    }
    return -1; // not found
}

class Program
{
    public static void Main()
    {
        int[] array = { 1, 3, 7, 12, 19, 32 };
        int n = 12;
        Console.WriteLine($"Linear Search result for the value {n} is at position: {LinearSearch(array, n)}");
        
        n = 32;
        Console.WriteLine($"Binary Search result for the value {n} is at position: {BinarySearch(array, n)}");
    }
}