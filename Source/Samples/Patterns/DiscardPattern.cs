namespace Samples.Patterns;

internal static class DiscardPattern
{
    internal static void SampleWithNullableEnum(DayOfWeek? dayOfWeek)
    {
        var discount = dayOfWeek switch
        {
            DayOfWeek.Monday => 0.5m,
            DayOfWeek.Tuesday => 12.5m,
            DayOfWeek.Wednesday => 7.5m,
            DayOfWeek.Thursday => 12.5m,
            DayOfWeek.Friday => 5.0m,
            DayOfWeek.Saturday => 2.5m,
            DayOfWeek.Sunday => 2.0m,
            _ => 0.0m,
        };
        Console.WriteLine($"Discount for {dayOfWeek?.ToString() ?? "unspecified"} is {discount}");
    }
}