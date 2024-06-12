using System;

class onedarray
{
    static void Main()
    {
        int[] numbers = { 15, 16, 8, 1, 4, 2, 5 };
        Console.WriteLine("Unsorted Array:");
        DisplayArray(numbers);        
        Array.Sort(numbers);
        Console.WriteLine("\n Sorted Array:");
        DisplayArray(numbers);
    }

    static void DisplayArray(int[] arr)
    {
        foreach (var num in arr)
        {
            Console.Write($"{num} ");
        }
        Console.WriteLine();
    }
}
