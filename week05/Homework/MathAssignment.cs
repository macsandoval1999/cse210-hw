public class MathAssignment : Assignment
// This class represents a math assignment with additional details like textbook section and problems.
// It inherits from the Assignment class.
{
    // -----MEMBER VARIABLES-----
    private string _textbookSection;
    private string _problems;

    // -----CONSTRUCTORS-----
    public MathAssignment() : base()
    // Default constructor initializes variables with "N/A"
    // It calls the default base class constructor
    {
        _textbookSection = "N/A";
        _problems = "N/A";
    }
    public MathAssignment(string studentName, string topic)
    // Constructor that initializes with specific student name and topic
    // It calls the default base class constructor
    // Used when textbook section and problems are not specified
        : base(studentName, topic)
    {
        _textbookSection = "N/A";
        _problems = "N/A";
    }
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    // Constructor that initializes with all things specified
    // It calls the base class constructor to fill in student name and topic
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // GETTERS AND SETTERS
    public string GetTextbookSection()
    {
        return _textbookSection;
    }
    public void SetTextbookSection(string textbookSection)
    {
        _textbookSection = textbookSection;
    }
    public string GetProblems()
    {
        return _problems;
    }
    public void SetProblems(string problems)
    {
        _problems = problems;
    }

    // METHODS
    public string GetHomeworkList()
    // Returns a formatted string for the textbook section and problems
    {
        return $"Section: {_textbookSection}, Problems: {_problems}";
    }

}