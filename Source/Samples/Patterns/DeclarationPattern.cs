using System.Collections;

namespace Samples.Patterns;

internal static class DeclarationPattern
{
    internal static void IsType()
    {
        object greeting = "Hello, World!";
        if (greeting is string s)
        {
            Console.WriteLine(s.ToLower());
        }
    }

    internal static void IsNotType()
    {
        object number = 123;
        if (number is not string s)
        {
            Console.WriteLine("Not string");
            //Console.WriteLine(s); // Not compilable
        }
    }

    internal static void InheritsFromType()
    {
        object values = new[] { 1, 2, 3 };
        if (values is Array array)
        {
            Console.WriteLine("It's an array of length " + array.Length);
        }
    }

    internal static void ImplementsInterface()
    {
        object values = new[] { 1, 2, 3 };
        if (values is IList list)
        {
            Console.WriteLine("It implements IList of count " + list.Count);
        }
    }

    internal static void Boxing()
    {
        int? xNullable = 7;
        int y = 23;
        object yBoxed = y;
        if (xNullable is int a && yBoxed is int b)
        {
            Console.WriteLine(a + b); 
        }
    }

}