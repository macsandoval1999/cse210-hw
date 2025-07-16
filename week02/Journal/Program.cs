// PROGRAM: Journal Program
// AUTHOR: Marco Sandoval
// DESCRIPTION:
// This program allows users to create, save, and load journal entries.
// It includes a menu for writing new entries, displaying all entries, saving to a file,
// and loading entries from a file.
// OTHER FILES: 
// Entry.cs - Contains the Entry class which represents a journal entry.
// Journal.cs - Contains the Journal class which manages a list of entries and file operations.
// PromptGenerator.cs - Contains the PromptGenerator class which provides random prompts for journal entries.
// EXCEEDING REQUIREMENTS:
// I improved the save and load functionality by allowing the user to choose whether to save to the current file or a new file. 
// I also included the current folder to display so that the user knows which journal they are currently working on. 
// The load function can also check if the file exists and will hand the error gracefully if it doesn't.

using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // ------Starting variables at the beginning of the program------
        // This will hold the current file name for the journal.
        string currentFile = "new-journal.csv";
        // Upon opening the program, we assume a new journal file is being created.
        // A new journal object is initialized.
        Journal journal = new Journal();
        // This will hold the user's choice from the menu. It is 0 to enter the loop.
        int option = 0;
        // The prompt generator is initialized.
        PromptGenerator prompts = new PromptGenerator();

        // Display a welcome message
        Console.WriteLine("Welcome to the Journal Program!");

        // Main loop to display the menu and handle user input
        while (option != 5)
        {
            // Display the current file name and the menu options
            Console.WriteLine($"Current file: {currentFile}");
            DisplayMenu();
            try
            {
                // Read the user's choice
                option = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                // If the input is not a valid integer, display an error message and continue
                Console.WriteLine();
                Console.WriteLine("[Error: Invalid input.]");
                Console.WriteLine();
                continue;
            }

            // OPTION1: Write a new entry
            if (option == 1)
            {
                // Create a new entry Object
                Console.WriteLine();
                Entry newEntry = new Entry();
                // Get the entry date from the system date and covert it to string in the format "MM/DD/YYYY"
                newEntry._date = DateTime.Now.ToString("MM/dd/yyyy");
                // Get the Prompt text from the PromptGenerator
                newEntry._promptText = prompts.GetRandomPrompt();
                // Get the entry text from the user              
                Console.WriteLine($"{newEntry._promptText}");
                Console.Write(">");
                newEntry._entryText = Console.ReadLine();
                // Add the new entry to the list of entries
                journal.AddEntry(newEntry);
            }

            // OPTION 2: Display all entries
            else if (option == 2)
            {
                // Display all entries in the journal
                journal.DisplayAll();
            }

            // Save entries to file
            else if (option == 3)
            {
                // Ask the user if they want to save to the current file or a new file
                Console.WriteLine("Would you like to save to the current file?: [yes]or[no]");
                string saveResponse = Console.ReadLine().ToLower();

                // Loop for valid input
                // While the response is not "yes" or "no", keep asking for a valid response
                while (saveResponse != "yes" && saveResponse != "no")
                {
                    {
                        Console.WriteLine();
                        Console.WriteLine("[Error: Invalid input.]");
                        Console.WriteLine();
                        Console.WriteLine("Would you like to save to the current file?: [yes]or[no]");
                        saveResponse = Console.ReadLine().ToLower();
                    }
                }

                // If the user wants to save to the current file
                if (saveResponse == "yes")
                {
                    // Save to current file
                    journal.SaveToFile(currentFile);
                }

                // If the user does not want to save to the current file, ask for a new file name
                else if (saveResponse == "no")
                {
                    Console.Write("Please enter a new file name to save your journal: ");
                    currentFile = Console.ReadLine();
                    journal.SaveToFile(currentFile);
                    Console.WriteLine($"[Your current file has changed to: {currentFile}]");
                    Console.WriteLine();
                }
                // If the response is invalid
                else
                {
                    Console.WriteLine("[Error: Invalid input.]");
                    saveResponse = Console.ReadLine().ToLower();
                }
            }

            // Load Journal from file
            else if (option == 4)
            {
                // Ask the user for the file name to load
                Console.Write("Please enter the file name to load your journal: ");
                string loadFile = Console.ReadLine();
                // Load the entries from the specified file
                try
                {
                    journal.LoadFromFile(loadFile);
                }
                catch (FileNotFoundException)
                {
                    // If the file is not found, display an error message
                    Console.WriteLine($"[Error: '{loadFile}' does not exist in the current directory.]");
                    Console.WriteLine();
                    continue; // Skip to the next iteration of the loop
                }
                // Update the current file name
                currentFile = loadFile;
                Console.WriteLine($"[Your current file has changed to: {currentFile}]");
                Console.WriteLine();
            }

            // Exit the program
            else if (option == 5)
            {
                Console.WriteLine("Exiting the program. Goodbye!");
            }

            // Handle invalid options
            else
            {
                Console.WriteLine();
                Console.WriteLine("[Error: Invalid input.]");
                Console.WriteLine();
            }
        }

    }



    // ---------------FUNCTIONS---------------
    static void DisplayMenu()
    // PURPOSE: Displays the menu options to the user.
    // PARAMETERS: None
    // RETURNS: Nothing
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display all entries");
        Console.WriteLine("3. Save Journal to file");
        Console.WriteLine("4. Load Journal from file");
        Console.WriteLine("5. Exit");
        Console.Write("What would you like to do? ");
    }
    
}