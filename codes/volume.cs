//Program to convert the volume given in ml to liter and ml.


using System;
public class Volume
{
    public static void Main(string[] args)
    {
        double ml;
        double l;
        Console.WriteLine("Enter volume in ml");
        ml = Convert.ToInt32(Console.ReadLine());
        l = ml / 1000;
        Console.WriteLine("The volume in liter is " + l + " and ml is " + ml);
    }
}