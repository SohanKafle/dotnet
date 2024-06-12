using System;

public class Practical
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your choice \n 1. Perimeter of square \n 2. Area of rectangle \n 3. Volume of cube");
        int choice = Convert.ToInt32(Console.ReadLine());

        int l, b; // Declare length and breadth variables outside the switch

        switch (choice)
        {
            case 1:
                Console.WriteLine("Enter the value of length");
                l = Convert.ToInt32(Console.ReadLine());
                int p = 4 * l;
                Console.WriteLine("The perimeter of square is " + p);
                break;

            case 2:
                Console.WriteLine("Enter the value of length");
                l = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the value of breadth");
                b = Convert.ToInt32(Console.ReadLine());
                int area = l * b;
                Console.WriteLine("The Area of rectangle is " + area);
                break;

            case 3:
                Console.WriteLine("Enter the value of length");
                l = Convert.ToInt32(Console.ReadLine());
                int v = l * l * l;
                Console.WriteLine("The volume of cube is " + v);
                break;

            default:
                Console.WriteLine("Enter your choice:");
                break;
        }
    }
}
