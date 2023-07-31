using System;
using System.Collections.Generic;
using System.Linq;
class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        myList.Remove(myList[index]);
        return myList;
    }
}