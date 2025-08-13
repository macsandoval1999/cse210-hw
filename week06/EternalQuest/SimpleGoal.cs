////////////////////////////
// SimpleGoal.cs
// This class represents a simple goal in the game.
// It inherits from the Goal class and provides specific functionality for simple goals.
// Simple goals are one-time goals that are either completed or not.
////////////////////////////

public class SimpleGoal : Goal
{
    // -----MEMBER VARIABLES-----
    private bool _isComplete; // Indicates if the goal is complete: True or False

    // -----CONSTRUCTORS-----
    public SimpleGoal(string shortName, string description, string points) : base(shortName, description, points)
    {
        _isComplete = false; // Default to incomplete
    }

    // -----GETTERS AND SETTERS-----
    public bool GetIsComplete()
    {
        return _isComplete;
    }
    public void SetIsComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }

    // -----METHODS-----
    public override void RecordEvent()
    // Use this to mark the goal as complete
    // Simple goals are one and done so this method will essentially give it a "complete" status
    {
        _isComplete = true;
    }
    public override bool IsComplete()
    // Check if the goal is complete
    // Remember, it is false until marked complete so it will return false unless RecordEvent() is called beforehand.
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    // Get a string representation of the goal to use for options 4 & 5 saving/loading file
    // This will later be split into parts using the '|' character.
    {
        return $"SimpleGoal|{GetShortName()}|{GetDescription()}|{GetPoints()}|{IsComplete()}";
    }
}