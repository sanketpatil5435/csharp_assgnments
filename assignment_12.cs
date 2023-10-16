using System;

class TemperatureChecker
{
    static void Main()
    {
        Console.Write("Enter a temperature: ");
        string userInput = Console.ReadLine();

        if (int.TryParse(userInput, out int temp))
        {
            string message = temp <= 15 ? "it is too cold here" :
                            temp >= 16 && temp <= 28 ? "it is ok" :
                            "it is hot here";
            Console.WriteLine(message);
        }
        else
        {
            Console.WriteLine("Not a valid Temperature");
        }
    }
}
