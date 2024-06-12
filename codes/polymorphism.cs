using System;

class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape");
    }
}

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

class Square : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a square");
    }
}

class Program
{
    static void DisplayInfo(string message)
    {
        Console.WriteLine("Info: " + message);
    }

    static void DisplayInfo(string message, int value)
    {
        Console.WriteLine("Info: " + message + " - Value: " + value);
    }

    public static void Main()
    {
        DisplayInfo("Static Polymorphism Example");
        DisplayInfo("Overloaded Method", 30);

        Shape shape = new Circle();
        shape.Draw(); 

        shape = new Square();
        shape.Draw(); 
    }
}
