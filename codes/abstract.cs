using System;

public abstract class Shape
{
    public abstract void Draw();
}

public class Circle : Shape
{
    public override void Draw() => Console.WriteLine("Lets Draw a circle.");
}

public class Square : Shape
{
    public override void Draw() => Console.WriteLine("Lets Draw a square.");
}

public class Program
{
    public static void Main()
    {
        Shape circle = new Circle();
        Shape square = new Square();

        circle.Draw();
        square.Draw();
    }
}
