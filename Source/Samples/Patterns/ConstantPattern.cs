using Samples.Common;

namespace Samples.Patterns;

internal static class ConstantPattern
{
    public static void IntSwitch(int input)
    {
        var output = input switch
        {
            1 => "I",
            5 => "V",
            10 => "X",
            50 => "L",
            100 => "C",
            500 => "D",
            1000 => "M",
            0 => "-",
            _ => throw new ArgumentException($"Not supported input: {input}", nameof(input)),
        };
        Console.WriteLine(output);
    }

    public static void EnumSwitch(Severity input)
    {
        var output = input switch
        {
            Severity.Low => "green",
            Severity.Medium => "yellow",
            //Severity.High => "red", // <-- missing arms hint
            //_ => "grey"
            _ => throw new ArgumentException($"Not supported input: {input}", nameof(input)),
        };
        Console.WriteLine(output);
    }

    private const string Constant1 = "a";
    private const string Constant2 = "b";
    private const string Constant3 = "b";

    public static void ConstantSwitch(string input)
    {
        var output = input switch
        {
            Constant1 => 1,
            Constant2 => 2,
            //Constant3 => 3, // <-- compilation error: Constant2 and Constant3 of same value
            _ => throw new ArgumentException($"Not supported input: {input}", nameof(input)),
        };
        Console.WriteLine(output);
    }

    internal static void IsNull()
    {
        object? expr = default;
        if (expr is null)
        {
            Console.WriteLine("Expression is null");
        }
    }

    internal static void IsNotNull()
    {
        object? message = "Message is not null";
        if (message is not null)
        {
            Console.WriteLine(message);
        }
    }
}