using System;
public class Employee
{
    public string Name { get; set; }
    public int EmployeeId { get; set; }
    public string Department { get; set; }

    public void DisplayEmployeeInfo()
    {
        Console.WriteLine($"Employee ID: {EmployeeId}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Department: {Department}");
        Console.WriteLine();
    }
}

public class EmployeeProgram
{
    public static void Main(string[] args)
    {
        Employee employee1 = new Employee { EmployeeId = 1, Name = "Sohan Kafle", Department = "IT" };
        Employee employee2 = new Employee { EmployeeId = 2, Name = "Subash Xettri", Department = "HR" };
        Employee employee3 = new Employee { EmployeeId = 3, Name = "Bibash Poudel", Department = "Finance" };

        Console.WriteLine("Employee Information:");
        employee1.DisplayEmployeeInfo();
        employee2.DisplayEmployeeInfo();
        employee3.DisplayEmployeeInfo();
    }
}
