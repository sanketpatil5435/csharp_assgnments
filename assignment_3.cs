using System;

class StringManipulation
{
    static void Main()
    {
        Console.Write("Enter a string here: ");
        string userString = Console.ReadLine();

        Console.Write("Enter the character to search: ");
        char searchChar = Console.ReadLine()[0];

        int charIndex = userString.IndexOf(searchChar);
        Console.WriteLine($"\nIndex of '{searchChar}' in the string: {charIndex}");

        Console.Write("\nEnter your first name: ");
        string userFirstName = Console.ReadLine();
        Console.Write("Enter your last name: ");
        string userLastName = Console.ReadLine();

        string userFullName = userFirstName + " " + userLastName;

        Console.WriteLine($"Full Name: {userFullName}");
    }
}
