using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static int GetNode(LinkedList<int> myList, int n)
    {
        if (myList == null || n >= myList.Count)
            return 0;
        LinkedListNode<int> node = myList.First;
        for (int i = 0; i < n; i++)
            node = node.Next;
        return node.Value;
    }
}
