using System;
public delegate void SimpleDelegate();
public class SimpleClass
{
    public void Method1()
    {
        Console.WriteLine("Method 1 is called successfully.");
    }

    public void Method2()
    {
        Console.WriteLine("Method 2 is called successfully.");
    }
}

public class Program
{
    public static void Main(string []args)
    {
        SimpleClass simpleObject = new SimpleClass();
        SimpleDelegate myDelegate = new SimpleDelegate(simpleObject.Method1);
        myDelegate();
        myDelegate = simpleObject.Method2;
        myDelegate();
    }
}
