using System;


public class HelloWorld
{
 
static int Sum_of_digits(int n){
if(n==0)
{return 0;
}
return (n%10)+Sum_of_digits(n/10);

} 
  
    public static void Main(string[] args)
    {
        Console.WriteLine ($"Sum is {Sum_of_digits(22)}");
    }
}


