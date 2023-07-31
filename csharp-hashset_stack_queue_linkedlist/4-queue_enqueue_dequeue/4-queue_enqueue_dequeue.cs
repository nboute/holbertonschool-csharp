using System.Collections;
using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        Console.WriteLine("Number of items: ", aQueue.Count);
        if (aQueue.Count == 0)
            Console.WriteLine("Queue is empty");
        else
            Console.WriteLine("First Item: ", aQueue.Peek());
        
        aQueue.Enqueue(newItem);
        if (aQueue.Contains(search))
        {
            Console.WriteLine("Queue contains {0}: \"{1}\"", search, aQueue.Contains(search));
            while (aQueue.Contains(search))
                aQueue.Dequeue();
        }
        return aQueue;
    }
}
