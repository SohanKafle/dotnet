using System;
public class Shape
{
    public virtual void ComputeArea()
    {
        Console.WriteLine("Area is:");
    }
}

public class Quadrilateral : Shape
{
    public void ComputeQuad()
    {
        Console.WriteLine("Quadrilateral Area is:");
    }
}

public class Circle : Shape
{
    public void ComputeCircle()
    {
        Console.WriteLine("Circle Area is:");
    }
}

public class Rectangle : Quadrilateral
{
    public void ComputeRect()
    {
        Console.WriteLine("Rectangle Area is:");
    }
}

public class Square : Quadrilateral
{
    public void ComputeSquare()
    {
        Console.WriteLine("Square Area is:");
    }
}

public class Test
{
    public static void Main(string[] args)
    {
        Rectangle r = new Rectangle();
        r.ComputeRect();
        r.ComputeQuad();
        r.ComputeArea();

        Square s = new Square();
        s.ComputeSquare();
        s.ComputeQuad();
        s.ComputeArea();

        Circle c = new Circle();
        c.ComputeCircle();
        c.ComputeArea();
    }
}
