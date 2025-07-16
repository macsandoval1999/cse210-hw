// This is the Journal class for the Journal Program. This class manages the entries within a Journal.
using System;
using System.Collections.Generic;
public class Journal
// PURPOSE: This class is responsible for managing journal entries.
// MEMBER VARIABLES: 
// - _entries: A list that holds all the entries in the journal.
// METHODS:
// - AddEntry: Adds a new entry to the journal.
// - DisplayAll: Displays all the entries in the journal.
// - SaveToFile: Saves the current journal entries to a file.
// - LoadFromFile: Loads journal entries from a file.
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    // PURPOSE: This method adds a new entry to the journal.
    // PARAMETERS:
    // - newEntry: An Entry object that contains the date, prompt text, and entry
    //   text to be added to the journal.
    // RETURNS: void
    {
        _entries.Add(newEntry);
        Console.WriteLine("[Entry added successfully!]");
        Console.WriteLine();
    }

    public void DisplayAll()
    // PURPOSE: This method displays all the entries in the journal.
    // PARAMETERS: None
    // RETURNS: void
    {
        Console.WriteLine("[Displaying all entries...]");
        foreach (Entry entry in _entries)
        {
            // Call the Display method on each entry
            entry.Display();
            Console.WriteLine(); // Add a blank line for better readability
        }
        Console.WriteLine("[End of entries]");
        Console.WriteLine();
    }
    public void SaveToFile(string filename)
    // PURPOSE: This method saves the current journal entries to a file.
    // PARAMETERS:
    // - filename: The name of the file where the journal entries will be saved.
    // RETURNS: void
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                // Write the date, prompt text, and entry text to the file
                outputFile.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
            }
        }
        Console.WriteLine($"[Journal saved to {filename} successfully!]");
        Console.WriteLine();
    }

    public void LoadFromFile(string filename)
    // PURPOSE: This method loads journal entries from a file.
    // PARAMETERS: 
    // - filename: The name of the file from which the journal entries will be loaded.
    // RETURNS: void
    {
        _entries.Clear(); // Clear existing entries before loading new ones
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            Entry entry = new Entry();
            entry._date = parts[0].Trim();
            entry._promptText = parts[1].Trim();
            entry._entryText = parts[2].Trim();
            _entries.Add(entry);
        }
        Console.WriteLine($"[Journal loaded from {filename} successfully!]");
        Console.WriteLine();
    }
}