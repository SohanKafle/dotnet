//Program to swap two numbers without using a third variable.

using System;
public class Swap
{
    public static void Main(string[]args)
    {
        int a, b;
        Console.WriteLine("Enter any two numbers");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine("The first number after swaping  is " + a + " and second is " + b);
    }
}