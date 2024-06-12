using System;
public class GenericContainer<T>
{
    private T data;

    public GenericContainer(T value)
    {
        data = value;
    }

    public void Display() => Console.WriteLine($"Data: {data}");
}
public class GenericMethods
{
    public static void Swap<T>(ref T a, ref T b)
    {
        T temp = a; a = b; b = temp;
    }
}
public class Program
{
    public static void Main()
    {
        GenericContainer<int> intContainer = new GenericContainer<int>(42);
        intContainer.Display();

        GenericContainer<string> stringContainer = new GenericContainer<string>("Hello, Sohan!");
        stringContainer.Display();

        int x = 12, y = 15;
        Console.WriteLine($"Before Swap: x={x}, y={y}");
        GenericMethods.Swap(ref x, ref y);
        Console.WriteLine($"After Swap: x={x}, y={y}");
    }
}
