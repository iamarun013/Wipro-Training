using System;
class Program{
    
    static int BinarySearch(int[] arr, int target)
    {
    
        int low=0;
        int high=arr.Length-1;
        while(low<=high)
        {
            int mid=(low+high)/2;
            if(arr[mid]== target)
            {
                return mid;
            }
            else if(arr[mid]< target)
            {
                low=mid+1;
            }
            else{
                high=mid-1;
            }
        }
        return -1;
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
           Console.WriteLine("Enter the number to find");

        int target=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Binary search");
        
        int result=BinarySearch(array, target);
        if(result==-1)
        Console.WriteLine("Element not found");
        else
        Console.WriteLine($"Element found at position :  {result}");
 }
}