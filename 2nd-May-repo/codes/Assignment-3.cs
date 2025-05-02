using System;
class Program{
static int c;
static int flag=1;

static void Recursive_Fibonacci(int a, int b, int n){
    
    if(flag==1)
    {
        Console.Write("0, 1");
        flag=0;
    }
    
    c=a+b;
    if(c>n){
    return;}
    else
    {
        Console.WriteLine($", {c}");
        Recursive_Fibonacci(b, c, n);
    }
    
    }


static void Main()
{
    Console.WriteLine("Enter a number to find fibonacci upto it");
    int n=Convert.ToInt32(Console.ReadLine());
    
    Recursive_Fibonacci(0, 1, n);
    

}
}