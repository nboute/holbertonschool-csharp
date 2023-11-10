using System;

/// <summary>
/// Represents an interactive object
/// </summary>
interface IInteractive
{
    void Interact();
}

/// <summary>
/// Represents a breakable object
/// </summary>
interface IBreakable
{
    int durability { get; set; }
    void Break();
}

/// <summary>
/// Represents a collectable object
/// </summary>
interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

/// <summary>
/// Base class
/// </summary>
public abstract class Base
{
    /// <summary>
    /// Name property
    /// </summary>
    public string name { get; set; }
    /// <summary>
    /// Override of the ToString method
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return $"{name} is a {this.GetType().Name}";
    }
}

/// <summary>
/// TestObject class that inherits from Base and all three interfaces
/// </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    /// <summary>
    /// Durability of the object
    /// </summary>
    public int durability { get; set; }

    /// <summary>
    /// Whether the object is collected
    /// </summary>
    public bool isCollected { get; set; }

    /// <summary>
    /// Interact implementation
    /// </summary>
    public void Interact()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Break implementation
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public void Break()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Collect implementation
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public void Collect()
    {
        throw new NotImplementedException();
    }
}
