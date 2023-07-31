using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> ptr = myLList.First;
        LinkedListNode<int> node = new LinkedListNode<int>(n);

        while (ptr != null && n > ptr.Value)
        {
            if (ptr.Next == null)
            {
                myLList.AddAfter(ptr, node);
                return node;
            }
            ptr = ptr.Next;
        }
        
        myLList.AddBefore(ptr, node);
        return node;
    }
}