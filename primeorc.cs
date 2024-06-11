// Program to find whether the given number is prime or composite.

using System; 
public class Example{
    public static void Main (string []args)
    {
        int num;
        int count=0;
        Console.WriteLine("Enter the number:");
        num=Convert.ToInt32(Console.ReadLine());
        int i;
        for(i=1;i<=num;i++)
        {
            if(num%i==0)
            {
                count++;
            }
        }
        if(count==2)
        {
            Console.WriteLine("The given number is prime number.");
        }
        else{
            Console.WriteLine("The given number is composite number.");
        }

    }
}