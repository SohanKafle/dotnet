// Program to find largest among three numbers using ternary operator.

using System;
public class Large
{
    public static void Main(string[] args)
    {
        int num1, num2, num3;

        Console.WriteLine("Enter first number:");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter third number:");
        num3 = Convert.ToInt32(Console.ReadLine());

        int largest = (num1 > num2 && num1 > num3) ? num1 : (num2 > num3 ? num2 : num3);
        Console.WriteLine("Largest among three numbers is: " + largest);
    }
}