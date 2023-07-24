using System;
using System.Collections.Generic;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> comb = new List<string>();
            for (int i = 0; i < 100; i++)
            {
                comb.Add(i.ToString("D2"));
            }
            Console.Write(String.Join(", ", comb) + "\n");
        }
    }
}
