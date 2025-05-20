using System;

public static void BubbleSort(int[] arr)
{
    int temp;
    for (int i = 0; i < arr.Length - 1; i++)
    {
        for (int j = 0; j < arr.Length - 1 - i; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
}

public static void InsertionSort(int[] arr1)
{
    for (int i = 1; i < arr1.Length; i++)
    {
        int key = arr1[i];
        int j = i - 1;
        while (j >= 0 && arr1[j] > key)
        {
            arr1[j + 1] = arr1[j];
            j--;
        }
        arr1[j + 1] = key;
    }
}

public static void SelectionSort(int[] arr2)
{
    int n = arr2.Length;
    for (int i = 0; i < n - 1; i++)
    {
        int min_index = i;
        for (int j = i + 1; j < n; j++)
        {
            if (arr2[j] < arr2[min_index]) // compare values
            {
                min_index = j;
            }
        }
        // Swap the found minimum element with the first element
        int temp = arr2[min_index];
        arr2[min_index] = arr2[i];
        arr2[i] = temp;
    }
}

class Program
{
    public static void Main()
    {
        int[] array = { 12, 22, 43, 30, 22, 13, 7, 9, 0, 2, 1, 3 };

        Console.WriteLine("Before sorting (BubbleSort):");
        for (int i = 0; i < array.Length; i++)
            Console.WriteLine(array[i]);

        BubbleSort(array);

        Console.WriteLine("\nAfter BubbleSort:");
        for (int i = 0; i < array.Length; i++)
            Console.WriteLine(array[i]);

        int[] array2 = { 12, 32, 23, 50, 12, 13, 17, 29, 0, 32, 1, 3 };

        Console.WriteLine("\nBefore InsertionSort:");
        for (int i = 0; i < array2.Length; i++)
            Console.WriteLine(array2[i]);

        InsertionSort(array2);

        Console.WriteLine("\nAfter InsertionSort:");
        for (int i = 0; i < array2.Length; i++)
            Console.WriteLine(array2[i]);

        // Now test SelectionSort
        int[] array3 = { 45, 23, 89, 12, 78, 56, 34 };
        Console.WriteLine("\nBefore SelectionSort:");
        for (int i = 0; i < array3.Length; i++)
            Console.WriteLine(array3[i]);

        SelectionSort(array3);

        Console.WriteLine("\nAfter SelectionSort:");
        for (int i = 0; i < array3.Length; i++)
            Console.WriteLine(array3[i]);
    }
}