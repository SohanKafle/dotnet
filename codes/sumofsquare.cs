//Program to find sum of squares of digits of a number.


using System;
public class Sumofsquare
{
    public static void Main(string[] args)
    {
        int num, rem, S = 0;
        Console.WriteLine("Enter any number");
        num = Convert.ToInt32(Console.ReadLine());
        while (num != 0)
        {
            rem = num % 10;
            S = rem * rem + S;
            num /= 10;
        }
        Console.WriteLine("Square is " + S);
    }
}