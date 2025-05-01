using System;
class Program{
    
    static void insertionsort(int[] arr, int n)
    {
        int key;
        for(int i=1;i<n;i++)
        {
            int j=i-1;
            key=arr[i];
            while(j>=0 && arr[j]>key){
            arr[j+1]=arr[j];
            j=j-1;
            }
            arr[j+1]=key;
        }
        Console.WriteLine("Array after insertion sort");

         for(int i=0;i<n;i++)
        {
            Console.WriteLine($"{arr[i]}");
        }
    }
    static void Main()
    {
        Console.WriteLine("Enter the number of elements to be in the array");
        int n=Convert.ToInt32(Console.ReadLine());
        int[] array=new int[n];
        for(int i=0;i<n;i++)
        {
            Console.WriteLine("Enter a number :");
            array[i]=Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Array before insertion sort");

         for(int i=0;i<n;i++)
        {
            Console.WriteLine($"{array[i]}");
        }
        
        insertionsort(array, n);
    }
}