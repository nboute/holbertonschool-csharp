using System;
using System.Collections.Generic;
using System.Linq;
class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList == null || myList.Count == 0)
            return "None";
        var max = myList.Values.ToList().Max();
        return myList.FirstOrDefault(d => d.Value == max).Key;
    }
}