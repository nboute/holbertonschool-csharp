using System;

class List
{
    public static System.Collections.Generic.List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        var list = new System.Collections.Generic.List<int>();
        for (int i = 0; i < size; i++)
            list.Add(i);
        Console.WriteLine(string.Join(" ", list));
        return list;
    }
}
