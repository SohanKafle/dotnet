using System;
public class Consdes
{
public Consdes(string message)
{
Console.WriteLine(message);
}
public void test()
{
Console.WriteLine("This is a method.");
}
~Consdes()
{
Console.WriteLine("This is a destructor.");
Console.ReadKey();
}
}
class Construct
{
static void Main(string []args)
{
string msg = "This is a constructor";
Consdes obj = new Consdes(msg);
obj.test();
}
}
