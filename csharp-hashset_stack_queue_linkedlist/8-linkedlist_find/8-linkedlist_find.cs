using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        if (myLList.Contains(value) == false)
            return (-1);
        LinkedListNode<int> node = myLList.First;
        int i = 0;
        while (node.Value != value)
        {
            node = node.Next;
            i++;
        }
        return i;
    }
}