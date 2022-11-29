namespace Samples.Patterns;

internal static class RelationalPattern
{
    internal static void RelationalSwitch(double temperature)
    {
        var output = temperature switch
        {
            < -20 => "Too cold",
            < 8 => "Cold",
            > 30 => "Too hot",
            double.NaN => "Unknown",
            _ => "Normal temperature",
        };
        Console.WriteLine(output);
    }
}