using System;

public delegate void MultiDelegate();

public class MultiClass
{
    public void Method1() => Console.WriteLine("Method 1 is called successfully.");
    public void Method2() => Console.WriteLine("Method 2 is called successfully.");
    public void Method3() => Console.WriteLine("Method 3 is called successfully.");
}

public class Program
{
    public static void Main()
    {
        MultiClass multiObject = new MultiClass();
        MultiDelegate multiDelegate = multiObject.Method1;
        multiDelegate += multiObject.Method2;
        multiDelegate += multiObject.Method3;
        multiDelegate();
        multiDelegate -= multiObject.Method2;
        Console.WriteLine("\nAfter removing Method2:");
        multiDelegate();
    }
}
