// Program to demonstrate the arithmetic operation.


using System;
public class Arithmetic
{
    public static void Main(string[] args)
    {
        int a, b, Add, Sub, Mul, Div;
        Console.WriteLine("Enter the value of  a and b");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        Add = a + b;
        Sub = a - b;
        Mul = a * b;
        Div = a / b;
        Console.WriteLine("The Sum is " + Add);
        Console.WriteLine("The difference is " + Sub);
        Console.WriteLine("The multiplication is " + Mul);
        Console.WriteLine("The division is " + Div);
    }
}
