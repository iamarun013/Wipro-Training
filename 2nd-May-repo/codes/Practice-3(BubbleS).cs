using System;
class Program{
    
    static void BubbleSort(int[] arr, int n)
    {
        int temp=0; 
    for(int i=0;i<n-1;i++)
    {
        for(int j=0;j<n-i-1;j++)
        {
            if(arr[j]>arr[j+1])
            {
                temp=arr[j];
                arr[j]=arr[j+1];
                arr[j+1]=temp;
            }
            
        }
    }
    

    }
    static void printArray(int[] arr)
    {
        for(int i=0;i<arr.Length;i++)
        {
            Console.Write(arr[i]+", ");
        }
        Console.WriteLine();
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
        BubbleSort(array, n);
        printArray(array);
           }
    
}