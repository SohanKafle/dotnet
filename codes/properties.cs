using System;
public class Person
{
    public string Name { get; set; }
    public int Age { get; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}
public class Program
{
    public static void Main(string []args)
    {
        Person person = new Person("Soham", 20);

        Console.WriteLine("Person Information:");
        person.DisplayInfo();
        person.Name = "Sohan";
        Console.WriteLine("\nUpdated Person Information:");
        person.DisplayInfo();
    }
}
