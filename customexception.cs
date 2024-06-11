using System;
public class CustomException : Exception
{

    public CustomException(string message) : base(message)
    {
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {

            throw new CustomException("This is a custom exception.");
        }
        catch (CustomException ex)
        {
            Console.WriteLine("Custom Exception Caught: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("General Exception Caught: " + ex.Message);
        }
    }
}
