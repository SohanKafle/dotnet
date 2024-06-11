using System;
class MyCollege
{
    public static string CollegeName;
    public static string Address;

    static MyCollege()
    {
        CollegeName = "Lumbini ICT Campus";
        Address = "Nawalpur";
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(MyCollege.CollegeName);
        Console.WriteLine(MyCollege.Address);
        Console.Read();
    }
}
