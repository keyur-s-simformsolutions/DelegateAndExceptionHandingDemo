using System;

// Define a custom delegate that has a string parameter and returns void.
delegate void CustomDel(string s);

class MultiClass
{
    // Define two methods that have the same signature as CustomDel.
    public static void Hello(string s)
    {
        Console.WriteLine($"  Hello, {s}!");
    }

    public static void Goodbye(string s)
    {
        Console.WriteLine($"  Goodbye, {s}!");
    }
}
