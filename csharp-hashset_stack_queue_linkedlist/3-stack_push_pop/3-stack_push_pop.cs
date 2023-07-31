using System;
using System.Collections.Generic;


class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        var count = aStack.Count;
        Console.WriteLine("Number of items: " + count);
        if (count > 0)
            Console.WriteLine("Top item: " + aStack.Peek());
        else
            Console.WriteLine("Stack is empty");
        bool contains = aStack.Contains(search);
        Console.WriteLine("Stack contains \"{0}\": {1}", search ,contains);
        while (aStack.Contains(search))
            aStack.Pop();
        aStack.Push(newItem);
        return aStack;
    }
}