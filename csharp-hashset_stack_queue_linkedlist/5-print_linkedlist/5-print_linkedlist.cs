using System;
using System.Collections.Generic;
using System.Linq;

class LList
{

    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> list = new LinkedList<int>();
        if (size <= 0)
            return list;
        for (int i = 0; i < size; i++)
            list.AddLast(i);
        Console.WriteLine(String.Join("\n", list.ToList()));
        return list;
    }
}