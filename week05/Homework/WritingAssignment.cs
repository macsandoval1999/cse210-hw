public class WritingAssignment : Assignment
// This class represents a writing assignment with additional details like title.
// It inherits from the Assignment class.
{
    // -----MEMBER VARIABLES-----
    private string _title;

    // -----CONSTRUCTORS-----
    public WritingAssignment() : base()
    // Default constructor initializes title with "N/A"
    // It calls the default base class constructor
    {
        _title = "N/A";
    }
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    // Constructor that initializes with all things specified
    // It calls the base class constructor to fill in student name and topic
    {
        _title = title;
    }

    // GETTERS AND SETTERS
    public string GetTitle()
    {
        return _title;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }

    // METHODS
    public string GetWritingInformation()
    // Returns a formatted string for the title, student name, and topic
    {
        return $"{GetTitle()} by {GetStudentName()} - {GetTopic()}";
    }
}