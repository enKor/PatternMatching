using Samples.Common;

namespace Samples.Patterns;

internal static class PositionalPattern
{
    internal static void DeconstructSwitch(Point point)
    {
        var output = point switch
        {
            (0, 0) => "Origin",
            (1, 0) => "positive X basis end",
            (0, 1) => "positive Y basis end",
            _ => "Just a point",
        };
        Console.WriteLine(output);
    }

    internal static void DeconstructSwitchCombined(Point point)
    {
        var output = point switch
        {
            (0, 0, 0) => "3D Origin",
            (0, 0, > 0 or < 0) => "Somewhere else on Z axis",
            (0, 0, null) => "2D Origin",
            (_, _, null) => "Any 2D point",
            (_, _, _) => "Any 3D point",
        };
        Console.WriteLine(output);
    }
    
    internal static void DeconstructSwitchTyped(object point)
    {
        var output = point switch
        {
            Point2D(> 0, > 0) p => p.ToString(),
            Point3D(> 0, > 0, > 0) p => p.ToString(),
            _ => "non positive point",
        };
        Console.WriteLine(output);
    }

    internal static void DeconstructIsCombined()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
        if (DataHelper.SumAndCount(numbers) is (Sum: var sum, Count: > 0))
        {
            Console.WriteLine($"Sum of [{string.Join(" ", numbers)}] is {sum}");
        }
    }
    
    internal static void PropertyPatternWithinPositionalPattern(WeightedPoint point)
    {
        var isPointInDomain = point is (>= 0, >= 0) { Weight: >= 0.0 };
        Console.WriteLine($"{point} {nameof(isPointInDomain)}: {isPointInDomain}");
    }
}