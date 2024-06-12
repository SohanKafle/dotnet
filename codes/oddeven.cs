//  Program to find whether the number is odd or even using a ternary operator.

using System;
public class Oddeven
{
    public static void Main(string[] args)
    {
        int a;
        Console.WriteLine("Enter any number");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(a % 2 == 0 ? "The number is even":"The number is odd");
    }
}