using System;

class JaggedArray
{
    static void Main()
    {
        int[][] jaggedArray = new int[3][];
        jaggedArray[0] = new int[] { 1, 2, 3 };
        jaggedArray[1] = new int[] { 4, 5, 6, 7 };
        jaggedArray[2] = new int[] { 8, 9 };

        Console.WriteLine("Jagged Array Elements:");
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            Console.Write($"Row {i + 1}: ");
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write($"{jaggedArray[i][j]} ");
            }
            Console.WriteLine();
        }
    }
}
