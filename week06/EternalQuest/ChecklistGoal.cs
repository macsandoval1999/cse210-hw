///////////////////////////////////////
// ChecklistGoal.cs
// This class represents a checklist goal in the game.
// It inherits from the Goal class and provides specific functionality for checklist goals.
// Checklist goals are goals that require multiple steps to complete.
// They keep track of how many steps have been completed and how many are left.
///////////////////////////////////////

public class ChecklistGoal : Goal
{
    // -----MEMBER VARIABLES-----
    private int _amountCompleted; // Tracks the number of times this goal has been completed
    private int _target; // The target number of completions needed to earn the bonus for this goal
    private int _bonus; // The bonus points awarded for completing this target

    // -----CONSTRUCTORS-----
    public ChecklistGoal(string shortName, string description, string points, int target, int bonus) : base(shortName, description, points)
    {
        _amountCompleted = 0; // Default to 0 completed
        _target = target;
        _bonus = bonus;
    }
    public ChecklistGoal(string shortName, string description, string points, int target, int bonus, int amountCompleted) : base(shortName, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted; // restore saved progress
    }

    // -----GETTERS AND SETTERS-----
    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }
    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }
    public int GetTarget()
    {
        return _target;
    }
    public void SetTarget(int target)
    {
        _target = target;
    }
    public int GetBonus()
    {
        return _bonus;
    }
    public void SetBonus(int bonus)
    {
        _bonus = bonus;
    }

    // -----METHODS-----
    public override void RecordEvent()
    // Use this to mark the goal as complete. Each time it is called
    // it will add 1 to the amount completed each time an event is recorded.
    // Later code will check if the goal is complete and award the bonus if it is.
    {
        if (_amountCompleted < _target) // if amount completed is less than target
        {
            _amountCompleted++; // Increment the amount completed by 1
        }
    }
    public override bool IsComplete()
    // Check if the goal is complete
    // A goal is complete if the amount completed is equal to the target
    // Use this to determine if the bonus should be awarded in later code
    {
        if (_amountCompleted == _target) // if amount completed is equal to target
        {
            return true; // Goal is complete and eligible for bonus
        }
        return false; // Goal is not complete
    }
    public override string GetDetailsString()
    // Get a detailed string representation of the goal's progress to use in option 2: List Goals
    {
        return $"{GetShortName()} ({GetDescription()}) -- Currently completed: {GetAmountCompleted()}/{GetTarget()}";
    }
    public override string GetStringRepresentation()
    // Get a string representation of the goal for options 4 & 5 saving/loading file
    // This will later be split into parts using the '|' character.
    {
        return $"ChecklistGoal|{GetShortName()}|{GetDescription()}|{GetPoints()}|{GetTarget()}|{GetBonus()}|{GetAmountCompleted()}";
    }
}