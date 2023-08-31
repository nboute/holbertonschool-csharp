using System;

/// <summary>
/// Represents an object.
/// </summary>
class Obj
{
    /// <summary>
    /// Determines if the subclass is a subclass of the superclass.
    /// </summary>
    /// <param name="subclass"></param>
    /// <param name="superclass"></param>
    /// <returns></returns>
    public static bool IsOnlyASubclass(Type subclass, Type superclass)
    {
        return subclass.IsSubclassOf(superclass) && !subclass.Equals(superclass);
    }

}