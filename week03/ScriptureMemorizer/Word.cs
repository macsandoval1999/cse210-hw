public class Word
// This class represents a single word in a scripture, which can be hidden or shown.
// It provides methods to hide the word, show it, check if it is hidden, and get its display text.
// It uses a string to hold the actual text of the word and a boolean flag to indicate if it is hidden.
{
    // ---------------Member variables---------------
    private string _text; // The actual text of the word
    private bool _isHidden; // Flag to indicate if the word is hidden



    // ---------------Constructors---------------
    public Word(string text)
    // Constructor that initializes the word with the given text and sets it to visible
    // OBJECT PARAMETERS: Takes a string of text to initialize the word
    {
        // _text is initialized with the provided text
        _text = text;
        // _isHidden is initialized to false, meaning the word is visible
        _isHidden = false; // Each Word is visible by default
    }



    // ---------------Methods---------------
    public void Hide()
    // Function to hide a word
    // It sets the _isHidden flag to true, which we make use of when GetDisplayText is called and the word is displayed with underscores.
    // PARAMETERS: None
    // RETURNS: None
    {
        // Set the _isHidden flag to true
        // This will cause the word to be displayed as underscores when GetDisplayText is called
        _isHidden = true;
    }
    public void Show()
    // Function to show a hidden word
    // It sets the _isHidden flag to false, making the word visible again.
    // PARAMETERS: None
    // RETURNS: None
    {
        // Set the _isHidden flag to false
        // This will cause the word to be displayed as its actual text when GetDisplayText is called
        _isHidden = false;
    }
    public bool IsHidden()
    // Function to check if the word is hidden
    // It returns the value of the _isHidden flag.
    // PARAMETERS: None
    // RETURNS: A boolean indicating whether the word is hidden (true) or visible (false)
    {
        return _isHidden;
    }
    public string GetDisplayText()
    // Function to get the display text of the word
    // If the word is hidden, it returns underscores; otherwise, it returns the actual word
    // PARAMETERS: None
    // RETURNS: A string representing the word, either as underscores if hidden or the actual text
    {
        // if the word is hidden
        if (_isHidden == true)
        {
            // Return a new string instance with as many underscores as the length of the word
            return new string('_', _text.Length);
        }
        // Otherwise, return the actual word
        else
        {
            return _text;
        }
    }
}