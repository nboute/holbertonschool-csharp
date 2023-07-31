using System;
using System.Linq;
using System.Collections.Generic;
class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        var res = myDict.OrderBy(entry => entry.Key).ToList();
        foreach (var item in res)
        {
            Console.WriteLine(item.Key + ": " + item.Value);
        }
    }
}