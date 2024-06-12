//Program to find Sum = 1+ 2/2!+ 3/3!+ 4/4!...... upto n


using System;
public class Summ
{
    public static void Main(string[] args)
    {
        double n,i;
        double sum = 0;
        Console.WriteLine("Enter the value of N");
        n = Convert.ToDouble(Console.ReadLine());
        for ( i = 1; i <= n; i++)
        {
            double fact = 1, j;
            for (j = 1; j <= i; j++)
            {
                fact = fact * j;

            }
            sum = sum + i / fact ;
        }
        Console.WriteLine("The answer is " + sum);
    }
}