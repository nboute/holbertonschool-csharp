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


/// <summary>
/// Decoration class that inherits from Base and IInteractive
/// </summary>
public class Decoration : Base, IInteractive, IBreakable
{
    public bool isQuestItem = false;
    public int durability { get; set; }

    /// <summary>
    /// Decoration constructor
    /// </summary>
    /// <param name="name"></param>
    /// <param name="durability"></param>
    /// <param name="isQuestItem"></param>
    /// <exception cref="Exception"></exception>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
            throw new Exception("Durability must be greater than 0");
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    /// <summary>
    /// Interact implementation
    /// </summary>
    public void Interact()
    {
        if (durability <= 0)
            Console.WriteLine($"The {name} has been broken.");
        else if (isQuestItem == true)
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        else
            Console.WriteLine($"You look at the {name}. Not much to see here.");
    }

    /// <summary>
    /// Break implementation
    /// </summary>
    public void Break()
    {
        durability--;
        if (durability > 0)
            Console.WriteLine($"You hit the {name}. It cracks.");
        else if (durability == 0)
            Console.WriteLine($"You smash the {name}. What a mess.");
        else
            Console.WriteLine($"The {name} is already broken.");
    }
}


/// <summary>
/// Key class that inherits from Base and ICollectable
/// </summary>
public class Key : Base, ICollectable
{
    public bool isCollected { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="name"></param>
    /// <param name="isCollected"></param>
    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    /// <summary>
    /// Collect implementation
    /// </summary>
    public void Collect()
    {
        if (isCollected == false)
            Console.WriteLine($"You pick up the {name}.");
        else
            Console.WriteLine($"You have already picked up the {name}.");
        isCollected = true;
    }
}
