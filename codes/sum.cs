//Program to find Sum=1*1+2*2+3*3+4*4.....upto n*n


using System;
public class Sum
{
    public static void Main(string[] args)
    {
        int n , sum=0 ;
        Console.WriteLine("Enter the value of n");
        n = Convert.ToInt32(Console.ReadLine());
        for(int i = 1; i <= n; i++)
        {
            sum = sum + i * i;
        }
        Console.WriteLine("The sum is " + sum);
    }
}