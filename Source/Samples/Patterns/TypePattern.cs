﻿using System.Collections;
using Samples.Common;

namespace Samples.Patterns;

internal static class TypePattern
{
    internal static void IsType()
    {
        object greeting = "Hello, World!";
        if (greeting is string)
        {
            Console.WriteLine(greeting);
        }
    }

    internal static void IsNotType()
    {
        object number = 123;
        if (number is not string)
        {
            Console.WriteLine("Not string");
        }
    }

    internal static void InheritsFromType()
    {
        object values = new[] { 1, 2, 3 };
        if (values is Array)
        {
            Console.WriteLine("It's an array");
        }
    }

    internal static void ImplementsInterface()
    {
        object values = new[] { 1, 2, 3 };
        if (values is IList)
        {
            Console.WriteLine("Array implements IList");
        }
    }

    internal static void SwitchStatement(object obj)
    {
        switch (obj)
        {
            case Person p:
                Console.WriteLine("obj is a Person");
                Console.WriteLine($"Name of the person: {p.FirstName} {p.LastName}");
                break;

            case int i:
                Console.WriteLine("obj is an int");
                Console.WriteLine($"Value of the int: {i}");
                break;

            case double d:
                Console.WriteLine("obj is a double");
                Console.WriteLine($"Value of the double: {d}");
                break;

            default:
                Console.WriteLine("obj is some other type");
                break;
        }
    }

    internal static void SwitchExpression(object obj)
    {
        var message = obj switch
        {
            Array array => "It's array of length " + array.Length, // <-- to be commented out
            IReadOnlyList<int> list => "It implements IList of count " + list.Count,
            Person p => $"Name of the person: {p.FirstName} {p.LastName}",
            int i => $"Value of the int: {i}",
            double d => $"Value of the double: {d}",
            _ => "obj is some other type"
        };

        Console.WriteLine(message);
    }
}