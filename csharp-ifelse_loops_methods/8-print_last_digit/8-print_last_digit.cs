using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        var digit = Math.Abs(number % 10);
        Console.Write(digit);
        return digit;
    }
}
