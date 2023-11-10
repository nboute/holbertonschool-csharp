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
public class Door : Base, IInteractive
{
    /// <summary>
    /// Constructor implementation
    /// </summary>
    /// <param name="name"></param>
    public Door(string name = "Door")
    {
        this.name = name;
    }

    /// <summary>
    /// Interact implementation
    /// </summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {this.name}. It's locked.");
    }
}
