//Program to convert the time given in second to hour, minute and second.


using System;
public class Time
{
    public static void Main(string[] args)
    {
        double s;
        double m, h, d;
        Console.WriteLine("Enter The number in seconds");
        s = Convert.ToDouble(Console.ReadLine());
        m = s / 60;
        h = m / 60;
        d = h / 24;
        Console.WriteLine("The time in seconds is " + s + " , minutes is " + m + " , hour is " + h + " and Day is " + d);
    }
}