namespace Samples.Common;

internal static class DataHelper
{
    internal static (double Sum, int Count) SumAndCount(IEnumerable<int> numbers)
    {
        int sum = 0;
        int count = 0;
        foreach (int number in numbers)
        {
            sum += number;
            count++;
        }
        return (sum, count);
    }

    internal static int[] SimulateDataFetch(int countOfItems = 5)
    {
        var rand = new Random();
        return Enumerable
            .Range(start: 0, count: countOfItems)
            .Select(s => rand.Next(minValue: -10, maxValue: 11))
            .ToArray();
    }
}