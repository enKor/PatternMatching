using Samples.Common;

namespace Samples.Patterns;

internal static class LogicalPattern
{
    internal static void ConjunctiveSwitch(char c)
    {
        var output = c switch
        {
            >= 'a' and <= 'z' => "lower case letter",
            >= 'A' and <= 'Z' => "upper case letter",
            >= '0' and <= '9' => "digit",
            _ => "other character",
        };
        Console.WriteLine(output);
    }

    internal static void DisjunctiveIs()
    {
        object vehicle = new Truck();
        if (vehicle is Car or Bus)
        {
            Console.WriteLine("Vehicle for passengers");
        }
        else
        {
            Console.WriteLine("Vehicle for cargo");
        }
    }

    internal static void NegativeIs()
    {
        object vehicle = new Truck();
        if (vehicle is not Truck)
        {
            Console.WriteLine("Vehicle for passengers");
        }
        else
        {
            Console.WriteLine("Vehicle for cargo");
        }
    }


    internal static void CombinationSwitch(char c)
    {
        var output = c switch
        {
            >= 'a' and <= 'z' or >= 'A' and <= 'Z' => "letter",
            >= '0' and <= '9' => "digit",
            _ => "other character",
        };
        Console.WriteLine(output);
    }
}