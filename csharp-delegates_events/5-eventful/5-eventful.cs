using System;

/// <summary>
/// Represents a player.
/// </summary>
public class Player
{
    private string name;
    private float maxHp;
    private float hp;
    private string status;

    /// <summary> Event handler for HP changes. </summary>
    public EventHandler<CurrentHPArgs> HPCheck;

    /// <summary>
    /// Delegate to calculate health.
    /// </summary>
    /// <param name="amount"></param>
    public delegate void CalculateHealth(float amount);

    /// <summary>
    /// Player constructor.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="maxHp"></param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        if (maxHp > 0f)
            this.maxHp = maxHp;
        else {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            this.maxHp = 100f;
        }
        this.hp = maxHp;
        this.status = name + " is ready to go!";
        HPCheck += CheckStatus;
    }

    /// <summary>
    /// Print the player health.
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine("{0} has {1} / {2} health", name, hp, maxHp);
    }

    /// <summary>
    /// Reduce the player health.
    /// </summary>
    /// <param name="damage"></param>
    public void TakeDamage(float damage)
    {
        if (damage < 0f)
            damage = 0f;
        Console.WriteLine("{0} takes {1} damage!", name, damage);
        ValidateHP(hp - damage);
    }

    /// <summary>
    /// Increase the player health.
    /// </summary>
    /// <param name="heal"></param>
    public void HealDamage(float heal)
    {
        if (heal < 0f)
            heal = 0f;
        Console.WriteLine("{0} heals {1} HP!", name, heal);
        ValidateHP(hp + heal);
    }

    /// <summary>
    /// Validate the player's new health.
    /// </summary>
    /// <param name="newHp"></param>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0f)
            hp = 0f;
        else if (newHp > maxHp)
            hp = maxHp;
        else
            hp = newHp;
        OnCheckStatus(new CurrentHPArgs(hp));
    }

    /// <summary>
    /// Apply a modifier to a health value (heal/damage)
    /// </summary>
    /// <param name="baseValue"></param>
    /// <param name="modifier"></param>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
            return (baseValue * 0.5f);
        else if (modifier == Modifier.Strong)
            return (baseValue * 1.5f);
        else
            return (baseValue);
    }

    /// <summary>
    /// Checks the player's status and prints it.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (hp == maxHp)
            Console.WriteLine("{0} is in perfect health!", name);
        else if (hp >= (maxHp / 2))
            Console.WriteLine("{0} is doing well!", name);
        else if (hp >= (maxHp / 4))
            Console.WriteLine("{0} isn't doing too great...", name);
        else if (hp > 0)
            Console.WriteLine("{0} needs help!", name);
        else
            Console.WriteLine("{0} is knocked out!", name);
    }

    /// <summary>
    /// Prints a warning depending on the amount of health left.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void HPValueWarning(object sender, CurrentHPArgs e)
    {
        Console.BackgroundColor = ConsoleColor.Red;
        if (e.currentHp == 0)
            Console.Write("Health has reached zero!");
        else
            Console.Write("Health is low!");
        Console.ResetColor();
        Console.WriteLine();
    }

    /// <summary>
    /// Event handler for checking the player's status.
    /// </summary>
    /// <param name="e"></param>
    private void OnCheckStatus(CurrentHPArgs e)
    {
        if (e.currentHp <= maxHp / 4)
        {
            HPCheck += HPValueWarning;
        }
        else
        {
            HPCheck -= HPValueWarning;
        }
        HPCheck(this, e);
    }
}

/// <summary>
/// Modifier to apply to a health value.
/// </summary>
public enum Modifier
{
    /// <summary> Weak modifier (50%) </summary>
    Weak,
    /// <summary> Base modifier (100%) </summary>
    Base,
    /// <summary> Strong modifier (150%) </summary>
    Strong
}

/// <summary>
/// Calculate a new health value based on a modifier.
/// </summary>
/// <param name="baseValue"></param>
/// <param name="modifier"></param>
/// <returns></returns>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>
/// Event handler for current HP args.
/// </summary>
public class CurrentHPArgs : EventArgs
{
    /// <summary> Current HP </summary>
    public readonly float currentHp;

    /// <summary>
    /// CurrentHPArgs constructor.
    /// </summary>
    /// <param name="newHp"></param>
    public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
    }
}
