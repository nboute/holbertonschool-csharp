using System;

/// <summary>
/// Represents an object.
/// </summary>
class Obj
{
    /// <summary>
    /// Determines if the object is of type int.
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public static bool IsOfTypeInt(object obj)
    {
        return obj is int;
    }
}