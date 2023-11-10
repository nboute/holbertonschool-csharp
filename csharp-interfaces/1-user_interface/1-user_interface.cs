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
    public int durability { get; set; }
    public bool isCollected { get; set; }

    public void Interact()
    {
        throw new NotImplementedException();
    }

    public void Break()
    {
        throw new NotImplementedException();
    }

    public void Collect()
    {
        throw new NotImplementedException();
    }
}
