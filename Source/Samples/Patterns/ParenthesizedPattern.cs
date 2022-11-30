namespace Samples.Patterns;

internal static class ParenthesizedPattern
{
    internal static void Emphasize()
    {
        object expr = 100f;
        if (expr is not (float or double))
        {
            Console.WriteLine("not float or double");
        }
    }
    

    internal static void NoPrecedenceChange(char c)
    {
        var isLetter = c is (<= 'm' or (>= 'A' and <= 'Z'));
        Console.WriteLine(isLetter);
    }
    internal static void PrecedenceChange(char c)
    {
        var isLetter = c is ((<= 'm' or >= 'A') and <= 'Z');
        Console.WriteLine(isLetter);
    }
}