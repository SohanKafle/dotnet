// Program to find factorials of any number.


using System;
public class Fact{
    public static void Main (string []args)
    {
        int num;
        Console.WriteLine("Enter a number");
        num=Convert.ToInt32(Console.ReadLine());
        int i,fact=1;
        for(i=1;i<=num;i++)
        {
            fact=fact*i;
        }

        Console.WriteLine("Factorial of given number is:"+fact);
    }
}