//////////////////////////////
// EternalGoal.cs
// This class represents an eternal goal in the game.
// It inherits from the Goal class and provides specific functionality for eternal goals.
// Eternal goals are never completed and exist to keep the game organized.
// They are used to track ongoing objectives that persist throughout the game.
//////////////////////////////

public class EternalGoal : Goal
{
    // -----MEMBER VARIABLES-----
    // None. The base class already handles all member variables needed.

    // -----CONSTRUCTORS-----
    public EternalGoal(string shortName, string description, string points) : base(shortName, description, points)
    {
        // No additional initialization needed
    }

    // -----METHODS-----
    public override void RecordEvent()
    // Because this goal is eternal, it cannot be fully completed. It exists to keep later code organized and running smoothly. It is also required since they are marked abstract in the base class.
    {
        // Do nothing
    }
    public override bool IsComplete()
    // Because this goal is eternal, it cannot be fully completed. It exists to keep later code organized and running smoothly. It is also required since they are marked abstract in the base class.
    {
        return false; // Eternal goals are never complete
    }
    public override string GetStringRepresentation()
    // Get a string representation of the goal to use for options 4 & 5 saving/loading file
    // This will later be split into parts using the '|' character.
    {
        return $"EternalGoal|{GetShortName()}|{GetDescription()}|{GetPoints()}";

    }
}