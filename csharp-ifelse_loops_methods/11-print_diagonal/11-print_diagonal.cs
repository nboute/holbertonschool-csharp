using System;

    class Line
    {
        public static void PrintDiagonal(int length)
        {
            string line = "";
            int spacing = 0;
            while (length > 0)
            {
                line += new string(' ', spacing) +  "\\\n";
                length--;
                spacing++;
            }
            Console.WriteLine(line);
        }
    }
