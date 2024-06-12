using System;
public class Vector
{
    public int X { get; set; }
    public int Y { get; set; }

    public Vector(int x, int y)
    {
        X = x;
        Y = y;
    }
    public static Vector operator +(Vector v1, Vector v2) => new Vector(v1.X + v2.X, v1.Y + v2.Y);

    public void DisplayVector(string name) => Console.WriteLine($"{name}: ({X}, {Y})");
}
public class Program
{
    public static void Main()
    {
        Vector vector1 = new Vector(21, 31);
        Vector vector2 = new Vector(12, 14);

        Vector result = vector1 + vector2;

        vector1.DisplayVector("Vector1");
        vector2.DisplayVector("Vector2");
        result.DisplayVector("Result");
    }
}
