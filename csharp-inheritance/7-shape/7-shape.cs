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

/// <summary>
/// Represents a rectangle.
/// </summary>
class Rectangle : Shape
{
    /// Width of the rectangle.
    private int width;

    /// Height of the rectangle.
    private int height;

    /// <summary>
    /// Gets or sets the width.
    /// </summary>
    public int Width { 
        get { return width; }
        set {
            if (value < 0) {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            width = value;
        }
    }

    /// <summary>
    /// Gets or sets the height.
    /// </summary>
    public int Height { 
        get { return height; }
        set {
            if (value < 0) {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            height = value;
        }
    }

    /// <summary>
    /// Computes the area of the rectangle. Hides the inherited Area() method.
    /// </summary>
    /// <returns></returns>
    public new int Area()
    {
        return width * height;
    }

    /// <summary>
    /// Returns a string representation of the rectangle.
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return ($"[Rectangle] {width} / {height}");
    }
}