﻿using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        if (myLList == null || myLList.Count == 0)
            return (0);
        var value = myLList.First.Value;
        myLList.RemoveFirst();
        return value;
    }
}