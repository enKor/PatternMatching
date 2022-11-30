namespace Samples.Patterns;

internal static class ListPattern
{
    internal static void Is()
    {
        int[] numbers = { 1, 2, 3 };

        Console.WriteLine(numbers is [1, 2]);  // False
        Console.WriteLine(numbers is [1, 2, 3]);  // True
        Console.WriteLine(numbers is [1, 2, 4]);  // False
        Console.WriteLine(numbers is [1, 2, _]);  // True
        Console.WriteLine(numbers is [1, 2, 3, 4]);  // False
        Console.WriteLine(numbers is [0 or 1, <= 2, >= 3]);  // True
    }

    internal static void WholeSequenceWithDiscard()
    {
        List<int> numbers = new() { 1, 2, 3 };

        if (numbers is [_, var second, _])
        {
            Console.WriteLine($"The second element of a three-item list is {second}.");
        }
    }

    internal static void PartOfSequenceWithSlicePattern()
    {
        Console.WriteLine(new[] { 1, 2, 3, 4, 5 } is [> 0, > 0, ..]);  // True
        Console.WriteLine(new[] { 1, 1 } is [_, _, ..]);  // True
        Console.WriteLine(new[] { 0, 1, 2, 3, 4 } is [> 0, > 0, ..]);  // False
        Console.WriteLine(new[] { 1 } is [1, 2, ..]);  // False

        Console.WriteLine(new[] { 1, 2, 3, 4 } is [.., > 0, > 0]);  // True
        Console.WriteLine(new[] { 2, 4 } is [.., > 0, 2, 4]);  // False
        Console.WriteLine(new[] { 2, 4 } is [.., 2, 4]);  // True

        Console.WriteLine(new[] { 1, 2, 3, 4 } is [>= 0, .., 2 or 4]);  // True
        Console.WriteLine(new[] { 1, 0, 0, 1 } is [1, 0, .., 0, 1]);  // True
        Console.WriteLine(new[] { 1, 0, 1 } is [1, 0, .., 0, 1]);  // False
    }

    internal static void NestedSubPatternWithinSlicePattern(string message)
    {
            var result = message is ['a' or 'A', .. var innerPart, 'a' or 'A']
                ? $"Message {message} matches; inner part is '{innerPart}'."
                : $"Message {message} doesn't match.";
            Console.WriteLine(result);

    }

    internal static void NestedSubPatternWithinSlicePattern(int[] numbers)
    {
        var result = numbers is [< 0, .. { Length: 2 or 4 }, > 0] 
            ? "valid" 
            : "not valid";
        Console.WriteLine(result);
    }

}