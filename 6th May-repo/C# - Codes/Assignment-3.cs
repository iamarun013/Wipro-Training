using System;
class Program

{
    public static int secondlargest(int[] arr)
    {
        Array.Sort(arr);
        return arr[arr.Length - 2];
    }
    public static void Main()
    {
        Console.WriteLine($"Enter the array elements");
        int[] arr = new int[5];
        for (int i = 0; i < 5; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine($"Second Largest element in the array {secondlargest(arr)}");
    }
}
