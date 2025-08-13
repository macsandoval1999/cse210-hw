///////////////////////////
// Goal.cs
// This class represents a goal in the game.
// It provides the base functionality for different types of goals.
// This class is abstract and cannot be instantiated directly.
//////////////////////////

public abstract class Goal
{
    // -----MEMBER VARIABLES-----
    private string _shortName; //name of the goal
    private string _description; //description of the goal
    private string _points; //points awarded for completing the goal

    // -----CONSTRUCTORS-----
    public Goal(string shortName, string description, string points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    // -----GETTERS AND SETTERS-----
    public string GetShortName()
    // Get name of goal
    {
        return _shortName;
    }
    public void SetShortName(string shortName)
    // Set name of goal
    {
        _shortName = shortName;
    }
    public string GetDescription()
    // Get description of goal
    {
        return _description;
    }
    public void SetDescription(string description)
    // Set description of goal
    {
        _description = description;
    }
    public string GetPoints()
    // Get points awarded for completing the goal
    {
        return _points;
    }
    public void SetPoints(string points)
    // Set points awarded for completing the goal
    {
        _points = points;
    }

    // -----METHODS-----
    public virtual string GetDetailsString()
    // Get a detailed string representation of the goal to use for Option: 2 List Goals
    {
        return $"{_shortName} ({_description})";
    }
    public abstract void RecordEvent(); // Abstract method to record an event for the goal
    public abstract bool IsComplete(); // Abstract method to check if the goal is complete
    public abstract string GetStringRepresentation(); // Abstract method to get a string representation of the goal
}
