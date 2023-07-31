using System;
using System.Collections.Generic;
class Array
{
    public static int[] CreatePrint(int size)
    {
        int[] array;
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        if (size == 0)
            Console.Write("\n");
        var list = new List<int>();
        for (int i = 0; i < size; i++)
            list.Add(i);
        if (size != 0)
            Console.WriteLine(string.Join(", ", list));
        array = list.ToArray();
        return array;
    }
}
