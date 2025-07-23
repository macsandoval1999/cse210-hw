public class Reference
// This class represents a Scripture reference, which includes the book, chapter, and verse(s).
// It can handle both single verses and ranges of verses.
{
    // ---------------Member variables---------------
    private string _book; // The book of the Scripture
    private int _chapter; // The chapter of the Scripture
    private int _verse; // The verse of the Scripture
    private int _endVerse; // The ending verse of the Scripture (optional)



    // ---------------Constructors---------------
    public Reference(string book, int chapter, int verse)
    // Constructor for single verse reference.
    // Parameters: book, chapter, verse
    {
        _endVerse = 0; // Default to 0 if no end verse is provided
        _book = book; // Set the book of the Scripture
        _chapter = chapter; // Set the chapter of the Scripture
        _verse = verse; // Set the verse of the Scripture
    }
    public Reference(string book, int chapter, int verse, int endVerse)
    // Constructor for range of verses reference.
    // Parameters: book, chapter, verse, endVerse
    {
        _book = book; // Set the book of the Scripture
        _chapter = chapter; // Set the chapter of the Scripture
        _verse = verse; // Set the verse of the Scripture
        _endVerse = endVerse; // Set the ending verse of the Scripture
    }



    // ---------------Methods---------------
    public string GetDisplayText()
    // Function returns a string representation of the Scripture reference.
    // PARAMETERS: None
    // RETURNS: A string in the format "Book Chapter:Verse" or "Book Chapter:Verse-EndVerse"
    {
        // Check if the end verse is greater than 0 to determine the format
        if (_endVerse > 0)
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        else
            return $"{_book} {_chapter}:{_verse}";
    }
}