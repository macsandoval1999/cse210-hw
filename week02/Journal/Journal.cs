// This is the Journal class for the Journal Program. This class manages the entries within a Journal.
using System;
using System.Collections.Generic;
public class Journal
{
    // This is a list variable that holds all the entries in a journal.
    // Each entry is an instance of the Entry class.
    public List<Entry> _entries = new List<Entry>();

    // This is a method that adds a new entry to the current loaded journal.
    // It takes an Entry object as a parameter and adds it to the _entries list.
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
        Console.WriteLine("[Entry added successfully!]");
        Console.WriteLine();
    }

    // This is a method that displays all the entries in the journal.
    // It iterates through the _entries list and calls the Display method on each Entry object
    public void DisplayAll()
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

    // This is a method that saves the current journal entries to a file.
    // It takes a file name as a parameter and writes the entries to that file.
    public void SaveToFile(string filename)
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

    // This is a method that loads journal entries from a file.
    // It takes a file name as a parameter and reads the entries from that file.
    public void LoadFromFile(string filename)
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