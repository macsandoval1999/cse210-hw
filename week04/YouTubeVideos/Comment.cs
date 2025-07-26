public class Comment
{
    // MEMBER VARIABLES
    private String _author; // The author of the comment
    private String _text; // The comment itself

    // CONSTRUCTOR
    public Comment(String author, String text)
    {
        _author = author; // parameter 1 is assigned to _author
        _text = text; // parameter 2 is assigned to _text
    }

    // METHODS
    public void Display()
    // Displays the comment in a formatted way
    {
        Console.WriteLine($"    >{_text} - {_author}");
    }
}