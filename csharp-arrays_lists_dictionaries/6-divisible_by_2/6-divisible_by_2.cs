using System;
using System.Collections.Generic;

class List 
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        return myList.ConvertAll(item => item % 2 == 0);
    }
}
