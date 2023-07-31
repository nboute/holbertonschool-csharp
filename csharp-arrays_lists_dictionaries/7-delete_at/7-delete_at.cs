using System;
using System;
using System.Collections.Generic;
using System.Linq;
class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        if (index < 0 || index >= myList.Count())
            Console.WriteLine("Index is out of range");
        else
            myList.Remove(myList[index]);
        return myList;
    }
}