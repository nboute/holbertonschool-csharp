using System;
using System.Collections.Generic;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> comb = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                comb.Add(i);
            }
            Console.WriteLine(String.Join(", ", comb));
        }
    }
}
