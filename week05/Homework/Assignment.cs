public class Assignment
// This class represents a general assignment with a student name and topic.
{
    // -----MEMBER VARIABLES----- 
    private string _studentName;
    private string _topic;

    // -----CONSTRUCTORS-----
    public Assignment()
    // Default constructor initializes variables with "N/A"
    {
        _studentName = "N/A";
        _topic = "N/A";
    }
    public Assignment(string studentName, string topic) 
    // Constructor that initializes with specific student name and topic
    {
        _studentName = studentName;
        _topic = topic;
    }

    // -----GETTERS AND SETTERS-----
    public string GetStudentName()
    {
        return _studentName;
    }
    public void SetStudentName(string studentName)
    {
        _studentName = studentName;
    }
    public string GetTopic()
    {
        return _topic;
    }
    public void SetTopic(string topic)
    {
        _topic = topic;
    }

    // -----METHODS-----
    public string GetSummary()
    // Returns a formatted string for the student name and topic
    {
        return $"{_studentName} - {_topic}";
    }
}