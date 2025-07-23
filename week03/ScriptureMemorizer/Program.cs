// PROGRAM: Scripture Memorizer
// AUTHOR: Marco Sandoval
// DESCRIPTION: A program that generates a random scripture and hides three random words each time the user presses Enter, until all words are hidden.
// OTHER FILES: Scripture.cs, ScriptureLibrary.cs, Scriptures.csv, Reference.cs, Word.cs
// EXCEEDING REQUIREMENTS: I created a ScriptureLibrary class that is made up of a list of scriptures. It uses a method to load scriptures from a file. A random scripture is selected each time the program is ran. I also adjusted the HideRandomWords method so that it never hides the same word again.

using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        // Create a new ScriptureLibrary object called library.
        ScriptureLibrary library = new ScriptureLibrary();
        // Call the LoadScripturesFromFile method to load scriptures from a file into the library list.
        library.LoadScripturesFromFile("Scriptures.csv");
        // Get a random scripture from the library list.
        Scripture selectedScripture = library.GetRandomScripture();

        // Start an infinite loop which can only be stopped with a "break" trigger, or if the user types "quit".
        while (true)
        {
            // Clear the console
            Console.Clear();
            // Display the randomly selected scripture
            Console.WriteLine(selectedScripture.GetDisplayText());
            Console.WriteLine();
            // Prompt the user to press Enter to hide words or type "quit" to exit.
            Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");

            // Read the users response and store it in a variable called userResponse.
            string userResponse = Console.ReadLine();
            // If the user types "quit",
            if (userResponse.ToLower() == "quit")
            {
                // Break out of the loop.
                break;
            }

            // If the user presses enter and if the selected scripture is not completely hidden "false"
            if (!selectedScripture.IsCompletelyHidden())
            {
                // Hide three random words from the selected scripture
                selectedScripture.HideRandomWords(3); // Hide 3 words at a time
            }
            // If the user presses Enter and ends up in this block, that means IsCompletelyHidden returned true.
            else
            {
                // Clear the console
                Console.Clear();
                // Display the scripture text, at this point the word should be completely invisible
                Console.WriteLine(selectedScripture.GetDisplayText());

                Console.WriteLine("\n'Ask for wisdom and understanding, and you shall receive...' \n[Program end]");
                break;
            }
        }
    }
}