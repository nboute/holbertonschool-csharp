using System;
using System.Collections.Generic;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> comb = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    comb.Add(i.ToString() + j.ToString());
                }
            }
            Console.WriteLine(String.Join(", ", comb));
        }
    }
}
