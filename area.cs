//Program to find the area between two concentric circles.


using System;
public class Area
{
    public static void Main(string[] args)
    {
        double R, r;
        double Area, area,AREA ;
        Console.WriteLine("Enter the radius of bigger circle");
        R = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the radius of smaller circle");
        r = Convert.ToDouble(Console.ReadLine());
        Area = (22 / 7) * R * R;
        area = (22 / 7) * r * r;
        
        AREA = Area - area;
        Console.WriteLine("The area between two concentric circles is " + AREA);
    }
}