// Program to find the reverse of a number.

using System;
public class Reverse
{
    public static void Main(string[] args)
    {
        int num,rem=1,rev=0;

        Console.WriteLine("Enter the number:");
          num=Convert.ToInt32(Console.ReadLine());

       do{
        rem=num%10;
        rev=rev*10+rem;
        num=num/10;
       }
       while(num!=0);


        Console.WriteLine("Reverse of the given number is:"+rev);
    }
}