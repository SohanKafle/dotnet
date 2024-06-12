// Program to find whether the number is divisible by 5 and 7 both or not.


using System;
public class Divide
{
public static void Main(string[]args)
{
Console.WriteLine("Enter a number:");
int a= Convert.ToInt32(Console.ReadLine());
if(a%5==0 & a%7==0)
{
Console.WriteLine("The given number "+a+ " is divisible by 5 and 7");
}
else
{
Console.WriteLine("The given number "+a+ " isn't divisible by 5 and 7");
}
}
}