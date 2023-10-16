using System;

class StringManipulation
{
    static void Main()
    {
        string userInput;

        Console.WriteLine("Please enter a string and press enter: ");
        userInput = Console.ReadLine();

        string upper = userInput.ToUpper();
        Console.WriteLine("Uppercase: " + upper);

        string lower = userInput.ToLower();
        Console.WriteLine("Lowercase: " + lower);

        string trimmed = userInput.Trim();
        Console.WriteLine("Trimmed: " + trimmed);

        int substringLength = 5;
        string sub = userInput.Substring(0, Math.Min(substringLength, userInput.Length));
        Console.WriteLine("Substring: " + sub);
    }
}
