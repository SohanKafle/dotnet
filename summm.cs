//Program to find Sum=x-x2+x3-x4+x5 ……………… upto n


using System;
public class Summm
{
    public static void Main(string[] args)
    {
        int x, n;
        Console.WriteLine("Enter the value of x and n");
        x = Convert.ToInt32(Console.ReadLine());
        n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        for (int i = 3; i <= n; i++)
        {
            int power = 1;
            for (int j = 1; j <= i; j++)
            {
                power = power * x;
            }
            if (i % 2 == 0)
            {
                sum = sum - power;
            }
            else
            {
                sum = sum + power;
            }

        }
        Console.WriteLine("The value is " + sum);
    }
}