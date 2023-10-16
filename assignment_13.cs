using System;

class LoopProgram
{
    static void Main()
    {
        Console.WriteLine("Using For Loop:");
        PrintValuesUsingForLoop();
        
        Console.WriteLine("\nUsing While Loop:");
        PrintValuesUsingWhileLoop();
    }

    public static void PrintValuesUsingForLoop()
    {
        for (int value = -3; value <= 3; value++)
        {
            Console.WriteLine(value);
        }
    }

    public static void PrintValuesUsingWhileLoop()
    {
        int count = 3;
        while (count >= -3)
        {
            Console.WriteLine(count);
            count--;
        }
    }
}
