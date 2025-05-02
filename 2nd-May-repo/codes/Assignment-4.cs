using System;


public class HelloWorld
{
    static int rem;
static int sum=0;
static int Sum_of_digits(int n){
    if(n>0)
    {
        rem=n%10;
        sum+=rem;
       return Sum_of_digits(n/10);
    }
    else{
    return sum;} 
}
    public static void Main(string[] args)
    {
        Console.WriteLine ($"Sum is {Sum_of_digits(22)}");
    }
}