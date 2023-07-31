using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> ptr = myLList.First;
        while (ptr != null && n > ptr.Value)
            ptr = ptr.Next;
        LinkedListNode<int> node = new LinkedListNode<int>(n);
        myLList.AddBefore(ptr, node);
        return node;
    }
}