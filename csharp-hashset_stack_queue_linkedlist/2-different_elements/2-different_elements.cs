﻿using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        var list3 = new List<int>();
        foreach (var item in list1)
        {
            if (!list2.Contains(item))
                list3.Add(item);
        }
        foreach (var item in list2)
        {
            if (!list1.Contains(item))
                list3.Add(item);
        }
        list3.Sort();
        return list3;
    }
}