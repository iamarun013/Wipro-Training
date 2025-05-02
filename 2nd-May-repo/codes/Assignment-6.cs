using System;

public class HelloWorld
{
    static void PrintArray(int[] arr, int c, int n)
    {
        if(c<n)
        {
        Console.WriteLine(arr[c]);
        PrintArray(arr, c+1, n);
        }
        
    }
    public static void Main(string[] args)
    {
        int[] arr={1, 2, 3, 4, 5};
        int  n=5;
        PrintArray(arr, 0, n);
    }
}