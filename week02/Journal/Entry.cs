using System;
public class Entry
// PURPOSE: This class represents a single entry in a journal.
// MEMBER VARIABLES:
// - _date: The date the entry was saved, expected in the format "MM/DD/YYYY".
// - _promptText: The prompt text that was randomly generated for the entry.    
// - _entryText: The response of the entry.
// METHODS:
// - Display: Displays the entry information including date, prompt text, and entry text.
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
    }
}