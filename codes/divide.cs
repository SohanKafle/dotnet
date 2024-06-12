// Program to find whether the number is divisible by either 5 or 7 or not.


using System;
public class Divide
{
    public static void Main(string[] args)
    {
        int a;
        Console.WriteLine("Enter any number");
        a = Convert.ToInt32(Console.ReadLine());
        if (a % 5 == 0)
        {
            Console.WriteLine("The number is divisible by 5");
        }
        else if(a % 7==0)
        {
            Console.WriteLine("The number is divisible by 7");
        }
        else
        {
            Console.WriteLine("The number is not divisible by 5 or 7");
        }
    }
}