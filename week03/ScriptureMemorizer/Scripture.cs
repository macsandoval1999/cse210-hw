public class Scripture
// This class represents a Scripture, which includes a reference and the text of the scripture.
// It can hide random words from the scripture text and check if all words are hidden.
// It also provides methods to get the display text of the scripture and check if it is completely hidden.
// It uses a Reference object to hold the reference of the scripture and a list of Word objects to represent each word in the scripture text.
{
    // ---------------Member variables---------------
    private Reference _reference; // Reference Object, holds the reference of the scripture
    private List<Word> _words = new List<Word>(); // List of Word objects, each representing a word in the scripture text



    // ---------------Constructors---------------
    public Scripture(Reference reference, String text)
    // Constructor that initializes the scripture with a reference and text
    // OBJECT PARAMETERS: Takes a Reference object; Takes a string of text, splits the text into words, and initializes the _words list
    {
        // Assign the reference to the _reference member variable
        _reference = reference;

        // Create a new list of words by splitting the text into individual words. Split the text where there are spaces
        string[] words = text.Split(' ');
        // Loop through each word in the split text
        foreach (string word in words)
        {
            // Create a new Word object for each word and add it to the _words list
            _words.Add(new Word(word));
        }
    }



    // ---------------Methods---------------
    public void HideRandomWords(int numberToHide)
    // Function to hide a specified number of randomly selected words in the scripture. Hidden words cannot be ranomly selected again.
    // FUNCTION PARAMETERS: Takes an int amount of numbers "numberToHide", which specifies how many words to hide each time this function is called.
    // RETURNS: No return value, it modifies the _words list by hiding the specified number of words.
    {
        // Create a list to hold the indexes of visible words
        List<int> visibleIndexes = new List<int>();
        // Start a loop index 0 (i =  0), and loop as long as i is less than the count of _words, at increments of 1 meaning i increases by 1 each time.
        for (int i = 0; i < _words.Count; i++)
        {
            // Check if the word at index i is not hidden using the IsHidden() method of the Word class. This code means: if word in _words[i] is NOT true, meaning if the word is visible (not hidden)
            if (!_words[i].IsHidden())
            {
                // If the word is visible, add its index to the visibleIndexes list
                visibleIndexes.Add(i);
            }
        }
        // Create a Random object to generate random numbers
        Random randomNumbers = new Random();
        // Using the math class, find the smaller of the two numbers, and store it in wordsToHide. This makes sure when we reach two visible words and we're trying to hide three, we will only hide two for example.
        int wordsToHide = Math.Min(numberToHide, visibleIndexes.Count);
        // Start a loop that runs for the number of words to hide
        for (int i = 0; i < wordsToHide; i++)
        {
            // Using the Random object, generate a random index from the visibleIndexes list
            int pick = randomNumbers.Next(visibleIndexes.Count);
            // Use the randomly selected number "pick" to access the visibleIndexes list and get the index of the word to hide
            int wordIndex = visibleIndexes[pick];
            // Hide the word at the selected index
            _words[wordIndex].Hide();
            // Remove the index from the visibleIndexes list so it can't be picked again in this round
            visibleIndexes.RemoveAt(pick);
        }
    }
    public string GetDisplayText()
    // Function to get the display text of the scripture by concatenating the reference and the words
    // FUNCTION PARAMETERS: No parameters, it uses the _reference and _words member variables to create the display text.
    // RETURNS: A string that contains the reference and the words of the scripture, formatted for display.
    {
        // Create a string to hold the scripture text, and start it with the reference display text
        string scriptureText = _reference.GetDisplayText() + " ";
        // Then loop through each word in _words. 
        foreach (Word word in _words)
        {
            // Add each word with their display text to scriptureText.
            scriptureText += word.GetDisplayText() + " ";
        }
        // Finally, return the scriptureText after trimming any extra spaces.
        return scriptureText.Trim();
    }
    public bool IsCompletelyHidden()
    // Function to check if all words in the scripture are hidden
    // FUNCTION PARAMETERS: No parameters, it checks the _words member variable to see if all words are hidden.
    // RETURNS: A boolean value indicating whether all words are hidden (true) or not (false).
    {
        // Loop through each word in _words
        foreach (Word word in _words)
        {
            // Call the IsHidden() method on each word to check if it is hidden
            // !word.IsHidden() checks if the word is NOT hidden
            if (!word.IsHidden())
            {
                // If any word is not hidden
                return false; // If any word is visible, immediately return false and end the method.

            }
        }
        // If the loop completes without finding any visible words
        return true; // All words are hidden, return true.
    }
}