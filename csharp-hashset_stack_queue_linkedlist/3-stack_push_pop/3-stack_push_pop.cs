using System;
using System.Collections.Generic;


class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine("Number of items: " + aStack.Count);
        Console.WriteLine("Top item: " + aStack.Peek());
        bool contains = aStack.Contains(search);
        Console.WriteLine("Stack contains \"Javascript\": " + contains);
        while (aStack.Contains(search))
            aStack.Pop();
        aStack.Push(newItem);
        return aStack;
    }
}