namespace Samples.Common;

public record WeightedPoint(int X, int Y)
{
    public double Weight { get; set; }
}