using System;

/// <summary>
/// Represents an object.
/// </summary>
class Obj
{
    /// <summary>
    /// Prints the available properties and methods of an object.
    /// </summary>
    /// <param name="myObj"></param>
    public static void Print(object myObj)
    {
        Type objType = myObj.GetType();
        Console.WriteLine($"{objType.Name} Properties:");
        foreach (var prop in objType.GetProperties())
            Console.WriteLine(prop.Name);

        Console.WriteLine($"{objType.Name} Methods:");
        foreach (var method in objType.GetMethods())
            Console.WriteLine(method.Name);
    }
}