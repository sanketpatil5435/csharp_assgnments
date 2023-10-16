using System;

class DataParser
{
    public static void Main(string[] args)
    {
        string stringForFloat = "0.85";
        string stringForInt  = "12345";

        float parsedFloat = float.Parse(stringForFloat);
        int parsedInt = int.Parse(stringForInt );

        Console.WriteLine($"Parsed float: {parsedFloat}");
        Console.WriteLine($"Parsed int: {parsedInt}");
    }
}
