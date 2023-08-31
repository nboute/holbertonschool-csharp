using System;

/// <summary>
/// Represents an object.
/// </summary>
class Obj
{
    /// <summary>
    /// Determines if the object is an instance of type array or inherits from type array.
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public static bool IsInstanceOfArray(object obj)
    {
        return obj is Array;
    }

}