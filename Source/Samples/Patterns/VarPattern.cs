using Samples.Common;

namespace Samples.Patterns;

internal static class VarPattern
{
    internal static void TemporaryVariableIs(int absLimit)
    {
        if (DataHelper.SimulateDataFetch() is var tempResults
            && tempResults.Min() >= -absLimit
            && tempResults.Max() <= absLimit)
        {
            Console.WriteLine("acceptable "+tempResults.Length);
        }
        else
        {
            Console.WriteLine("not acceptable");
        }
    }

    internal static void TemporaryVariableSwitchUgly(Point2D point)
    {
        var newPoint = point is var (x, y)
            ? x == y
                ? new Point2D(y, x)
                : x < y
                    ? new Point2D(-x, y)
                    : new Point2D(x, -y)
            : throw new ArgumentException();
        Console.WriteLine($"{point} -> {newPoint}");
    }

    internal static void TemporaryVariableSwitchWithCaseGuard(Point2D point)
    {
        // Positional pattern equivalent

        var newPoint = point switch
        {
            var (x, y) when x < y => new Point2D(-x, y),
            var (x, y) when x > y => new Point2D(x, -y),
            var (x, y) => new Point2D(y, x),
        };
        Console.WriteLine($"{point} -> {newPoint}");
    }
}