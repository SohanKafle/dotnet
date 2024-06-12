using System;
interface Shape
{
    void computeArea(int l, int b);
}
class Reactangle:Shape
{
   public void computeArea(int l,int b)
    {
        int area = l*b;
        Console.WriteLine("Area is:"+area);
    }
}
public class Test
{
    public static void Main(string []args)
    {
        Reactangle r = new Reactangle();
        r.computeArea(2,3);
    }
}