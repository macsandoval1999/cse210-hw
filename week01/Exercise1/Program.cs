using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user for a first name from the console
        Console.Write("What is your first name? ");

        // Store the first name in a variable
        string firstName = Console.ReadLine();

        // Prompt the user for a last name from the console
        Console.Write("What is your last name? ");

        // Store the last name in a variable
        string lastName = Console.ReadLine();

        // print a blank line
        Console.WriteLine("");

        // Print the first name and last name in the format "Your name is <lastName>, <firstName> <lastName>"
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}");
    }
}