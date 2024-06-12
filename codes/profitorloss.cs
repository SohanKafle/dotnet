// Program to find profit amount or loss amount.


using System;
public class Example
{
    public static void Main(string[] args)
    {
        int sp,cp;

        Console.WriteLine("Enter Cost Price(cp):");
        cp = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Selling Price(sp):");
        sp = Convert.ToInt32(Console.ReadLine());

       int results=sp-cp;
      
        string result = results < 0 ? "loss: " + -1*results : "profit: " + results;

        Console.WriteLine( result);
    }
}