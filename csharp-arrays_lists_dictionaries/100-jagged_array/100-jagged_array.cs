using System;
using System.Collections.Generic;

namespace _100_jagged_arr_ay
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[] {0, 1, 2, 3};
            jaggedArray[1] = new int[] {1, 2, 3, 4, 5, 6};
            jaggedArray[2] = new int[] {0, 1};
            for (int i = 0; i < jaggedArray.GetLength(0); i++)
                Console.WriteLine(String.Join(" ", jaggedArray[i]));
        }
    }
}
