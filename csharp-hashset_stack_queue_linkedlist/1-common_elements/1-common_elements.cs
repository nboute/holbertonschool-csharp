﻿using System.Collections.Generic;
using System;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        var list3 = new List<int>();
        foreach (var item in list1)
        {
            if (list2.Contains(item))
                list3.Add(item);
        }
        list3.Sort();
        return list3;
    }
}
