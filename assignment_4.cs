using System;

class PrimitiveTypes
{
    static void Main()
    {
        int integerVar = 42; 
        double doubleVar = 3.14159; 
        bool booleanVar = true; 
        char charVar = 'A'; 
        byte byteVar = 200; 
        short shortVar = 15000; 
        long longVar = 9876543210L; 
        float floatVar = 2.34f; 
        decimal decimalVar = 45.678m; 

        string textString1 = "I control text";
        string numberString = "123";

        int parsedNumber = int.Parse(numberString);

        Console.WriteLine($"int: {integerVar}");
        Console.WriteLine($"double: {doubleVar}");
        Console.WriteLine($"bool: {booleanVar}");
        Console.WriteLine($"char: {charVar}");
        Console.WriteLine($"byte: {byteVar}");
        Console.WriteLine($"short: {shortVar}");
        Console.WriteLine($"long: {longVar}");
        Console.WriteLine($"float: {floatVar}");
        Console.WriteLine($"decimal: {decimalVar}");
        Console.WriteLine($"string 1: {textString1}");
        Console.WriteLine($"string 2: {numberString}");
        Console.WriteLine($"Parsed Number: {parsedNumber}");
    }
}
