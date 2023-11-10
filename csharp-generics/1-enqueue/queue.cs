using System;

/// <summary>
/// Represents a queue.
/// </summary>
/// <typeparam name="T"></typeparam>
class Queue<T>
{
    /// <summary>
    /// method that returns the Queue's type
    /// </summary>
    /// <returns></returns>
    public string CheckType()
    {
        return typeof(T).ToString();
    }


}

