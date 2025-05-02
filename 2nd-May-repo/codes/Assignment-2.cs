using System;
class Program{


static int Recursive_Factorial(int n){
    if(n>0)
    {
        return n * Recursive_Factorial(n-1); 
    }
    else
    return 1;
}

static void Main()
{
    Console.WriteLine("Enter a number to find it's factorial");
    int n=Convert.ToInt32(Console.ReadLine());
    if(n==0 || n==1)
    {
        Console.WriteLine($"Factoria of {n} is: 1");
    }
    else{
    int fact=Recursive_Factorial(n);
    Console.WriteLine($"Factoria of {n} is: {fact}");
}
}
}