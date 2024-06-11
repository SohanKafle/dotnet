// Program to find whether the number is palindrome or not.


using System;
public class Palindrome
{
    public static void Main(string[] args)
    {
        int num,rem=1,rev=0;

        Console.WriteLine("Enter the number:");
          num=Convert.ToInt32(Console.ReadLine());
          int temp=num;

       do{
        rem=num%10;
        rev=rev*10+rem;
        num=num/10;
       }
       while(num!=0);
       if(temp==rev)
       {
        Console.WriteLine("Given number is Palindrome.");

       }
       else{
        Console.WriteLine("Given number is not Palindrome.");

       }

    }
}