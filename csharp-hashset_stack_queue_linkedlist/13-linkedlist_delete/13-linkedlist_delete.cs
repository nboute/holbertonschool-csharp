using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        if (index < 0 || index >= myLList.Count)
            return;
        LinkedListNode<int> node = myLList.First;
        for (int i = 0; i < index; i++)
            node = node.Next;
        myLList.Remove(node);
    }
}