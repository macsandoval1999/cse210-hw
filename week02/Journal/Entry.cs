// This is the Entry class for the Journal Program. This class represents a single entry in a journal.
using System;
public class Entry
{
    // This is a string variable that holds the date the entry was saved. 
    // It is expected to be in the format "MM/DD/YYYY".
    public string _date;
    // This is a string variable that holds the prompt text that was randomly generated for the entry.
    public string _promptText;

    // This is a string variable that holds the response of the entry.
    public string _entryText;

    // This is a method that displays the entry information.
    // It prints the date, prompt text, and entry text to the console.
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
    }
}