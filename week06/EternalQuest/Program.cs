//////////////////////////////
// Program: Eternal Quest
// Author: Marco Sandoval
// Description: A gamified goal management system for tracking player progress. 
// Other files: Goal.cs, GoalManager.cs, SimpleGoal.cs, EternalGoal.cs, ChecklistGoal.cs
// Exceeding Requirements: When displaying a list of goals in the options: List Goals, and Record Event, Eternal Goals now appear with an infinity symbol (∞) next to them. The checkboxes now are also displayed when looking at what goal was accomplished during the Record Event process. I also implemented loading animations and pauses. Theres also error handling to keep the game experience smooth.

using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager(); // Create an instance of GoalManager
        manager.Start(); // Start the goal management process. It will run until the user chooses to quit. This works because the Start method contains a loop that continues until the user selects the quit option.
    }
}