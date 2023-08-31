using System;

/// <summary>
/// Represents a geometric shape.
/// </summary>
class Shape
{
    /// <summary>
    /// Computes the area, or throws an exception if not implemented.
    /// </summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}