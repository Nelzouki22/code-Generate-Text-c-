using System;

class Program
{
    static string GenerateText()
    {
        return "Hello from C#!";
    }

    static void Main()
    {
        string text = GenerateText();
        Console.WriteLine("Generated text: " + text);
    }
}
