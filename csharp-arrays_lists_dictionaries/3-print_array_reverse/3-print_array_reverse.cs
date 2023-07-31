using System;

class Array
{
    public static void Reverse(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            Console.WriteLine("");
            return;
        }
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[array.Length - i - 1]);
            if (i < array.Length - 1)
                Console.Write(" ");
            else
                Console.Write("\n");
        }
    }
}
