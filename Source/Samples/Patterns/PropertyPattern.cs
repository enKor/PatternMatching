using Samples.Common;

namespace Samples.Patterns;

internal static class PropertyPattern
{
    internal static void IsChristmasHoliday(DateTime date)
    {
        //if (date is { Year: 2022, Month: 12, Day: 24 or 25 or 26 })
        //{ ... }

        var output = date is { Year: 2022, Month: 12, Day: 24 or 25 or 26 };
        Console.WriteLine(output);
    }

    internal static void WriteFive(object input)
    {
        var five = input switch
        {
            string { Length: >= 5 } s => s[..5],
            string s => s,

            ICollection<char> { Count: >= 5 } symbols => new string(symbols.Take(5).ToArray()),
            ICollection<char> symbols => new string(symbols.ToArray()),

            null => throw new ArgumentNullException(nameof(input)),
            _ => throw new ArgumentException("Not supported input type."),
        };
        Console.WriteLine(five);
    }


    internal static void Nested(Segment segment)
    {
        var isAnyEndOnXAxis = segment is { Start: { Y: 0 } } or { End: { Y: 0 } };
        Console.WriteLine($"{nameof(isAnyEndOnXAxis)}:{isAnyEndOnXAxis}");
    }

    internal static void Extended(Segment segment)
    {
        var isAnyEndOnXAxis = segment is { Start.Y: 0 } or { End.Y: 0 };
        Console.WriteLine($"{nameof(isAnyEndOnXAxis)}:{isAnyEndOnXAxis}");
    }


}