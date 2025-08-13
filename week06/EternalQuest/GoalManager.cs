///////////////////////////////////////////////////////////
// GoalManager.cs
// This class manages the player's goals and tracks their progress.
// It provides methods for creating, listing, saving, loading, and recording events for goals.
// The GoalManager class is responsible for maintaining the list of goals and the player's score.
// It calls the appropriate methods on the Goal class to manage individual goals.
///////////////////////////////////////////////////////////

using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.IO;
using System;
using System.Threading;

public class GoalManager
{
    // -----MEMBER VARIABLES-----
    private List<Goal> _goals = new List<Goal>(); // List of all goals
    private int _score;

    // -----CONSTRUCTORS-----
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;  // Player's default score upon opening the program
    }

    // -----GETTERS AND SETTERS-----
    public List<Goal> GetGoals()
    {
        return _goals;
    }
    public int GetScore()
    {
        return _score;
    }
    public void SetScore(int score)
    {
        _score = score;
    }

    // -----METHODS-----
    public void Start()
    // This method starts the goal manager, displaying the menu and handling user input.
    // This function is basically the main loop of the program; the game runs here.
    {
        DisplayWelcomeMessage(); // Display the welcome message
        int choice = 0; // starting choice to enter loop
        while (choice != 6) // Enter Main Game loop
        {
            DisplayPlayerInfo(); // Display players score through method, then display menu options
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create new Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice from the menu: "); // Prompt and Read user choice input

            try
            {
                choice = int.Parse(Console.ReadLine()); // Parse the input to an integer
            }
            catch (FormatException) // If the input is not a valid integer, catch the exception
            {
                ShowSpinner(); // Show spinner to indicate processing
                Console.Clear(); // Clear the console for a fresh display
                Console.WriteLine("ERROR: Invalid input, please enter a number between 1 and 6.");
                Pause(); // Pause the program to allow the user to read the error message
                continue; // Skip to the next loop iteration, rewind to the beginning of the whileloop
            }

            if (choice < 1 || choice > 6) // First check if the choice is int between 1 and 6. If not, display error.
            {   ShowSpinner(); // Show spinner to indicate processing
                Console.Clear(); // Clear the console for a fresh display
                Console.WriteLine("ERROR: Invalid choice, please try again.");
                Pause(); // Pause the program to allow the user to read the error message
                continue; // Skip to the next loop iteration, rewind to the beginning of the loop
            }
            if (choice == 6) // Then check if user is quitting
            {
                Console.Clear();
                Console.WriteLine("Goodbye!");
                return; // Exit the start method, which takes you back to the Main Program file. The program will end here since there are no more instructions to execute.
            }

            ShowSpinner();
            Console.Clear();

            if (choice == 1) // If user chooses to create a new goal, run the CreateGoal method
            {
                CreateGoal();
            }
            else if (choice == 2) // If user chooses to list goals, run the ListGoalDetails method
            {
                ListGoalDetails();
            }
            else if (choice == 3) // If user chooses to save goals, run the SaveGoals method
            {
                SaveGoals();
            }
            else if (choice == 4) // If user chooses to load goals, run the LoadGoals method
            {
                LoadGoals();
            }
            else if (choice == 5) // If user chooses to record an event, run the RecordEvent method
            {
                RecordEvent();
            }
            else // If the choice is not valid, display an error message
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
    public void DisplayPlayerInfo()
    // This method displays the player's current score and other relevant information.
    {
        Console.WriteLine($"Current Score: {_score}");
        Console.WriteLine();
    }
    public void ListGoalNames()
    // This method lists the names of all goals the player has.
    // This is used to display the goals during the RecordEvent method.
    {
        if (_goals.Count == 0) // If there are no goals, exit the method which then takes you back to the beginning of the while loop
        {
            return;
        }
        for (int i = 0; i < _goals.Count; i++) // Loop through the list of goals starting from the first one, to however many there are in increments of 1. For each loop, display the short name of the goal.
        {
            string checkBox = "[ ]"; // Initiate checkbox with default unchecked state  
            if (_goals[i].IsComplete()) // if the goal is complete, mark it as such. Otherwise it'll remain the default unchecked state.
            {
                checkBox = "[X]";
            }
            else if (_goals[i] is EternalGoal) // But if the goal is eternal, mark it as such.
            {
                checkBox = " ∞ ";
            }
            Console.WriteLine($"{i + 1}. {checkBox} {_goals[i].GetShortName()}"); // using method from Goal class
        }
    }
    public void ListGoalDetails()
    // This method lists the details of all goals the player has, including their points and descriptions.
    // It also shows the current status of each goal (complete/incomplete).
    // This is the method used to display goal details in Option 2
    {
        if (_goals.Count == 0) // If there are no goals, tell the user, then exit the method which then takes you back to the beginning of the while loop.
        {
            Console.WriteLine("You currently have no goals.");
            Pause();
            return;
        }

        Console.WriteLine("Current Goals:"); // Display the current goals
        Console.WriteLine("-------------");

        int index = 1;
        foreach (var goal in _goals) // For each goal in the list of goals
        {
            string checkBox = "[ ]"; // Initiate checkbox with default unchecked state

            if (goal.IsComplete()) // if the goal is complete, mark it as such. Otherwise it'll remain the default unchecked state.
            {
                checkBox = "[X]";
            }
            else if (goal is EternalGoal) // But if the goal is eternal, mark it as such.
            {
                checkBox = " ∞ ";
            }

            Console.WriteLine($"{index}. {checkBox} {goal.GetDetailsString()}"); // Formatted Goals

            index++; // Increment the index for the next goal
        }

        Pause(); // Pause the program to allow the user to read the details
    }
    public void CreateGoal()
    // This method creates a new goal based on user input.
    // It prompts the user for the type of goal, name, description, and points.
    // It is the method to be used for Option 1
    {
        Console.WriteLine("The types of Goals are:"); // Display goal types
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");

        Console.Write("Which type of goal would you like to create? "); // Prompt and read for goal type
        int newGoalType; // Initialize newGoalType variable to store user input

        try
        {
            newGoalType = int.Parse(Console.ReadLine());
        }
        catch (FormatException) // if the input is not a valid integer
        {
            ShowSpinner(); // Show spinner to indicate processing
            Console.Clear(); // Clear the console for a fresh display
            Console.WriteLine("ERROR: Invalid input, please enter a number.");
            Pause();
            return;
        }

        if (newGoalType < 1 || newGoalType > 3)
        {
            ShowSpinner(); // Show spinner to indicate processing
            Console.Clear(); // Clear the console for a fresh display
            Console.WriteLine("ERROR: Invalid goal type, please enter a number between 1 and 3.");
            Pause();
            return;
        }

        Console.Write("Enter the goal name: "); // Prompt and read for goal name
        string goalName = Console.ReadLine();

        Console.Write("Enter the goal description: "); // Prompt and read for goal description
        string goalDescription = Console.ReadLine();

        Console.Write("Enter the goal points: "); // Prompt and read for goal points
        string goalPoints = Console.ReadLine();

        int validateGoalPoints = 0; // Initialize variable to store converted goal points to int to validate if goalpoints is int.
        if (!int.TryParse(goalPoints, out validateGoalPoints)) // if goalPoints cannot be converted to int
        {
            ShowSpinner(); // Show spinner to indicate processing
            Console.Clear(); // Clear the console for a fresh display
            Console.WriteLine("ERROR: Invalid input for goal points, please enter a valid number.");
            Pause();
            return;
        }

        if (newGoalType == 1) // If the user selected Simple Goal, create a new SimpleGoal object and add it to the list
        {
            _goals.Add(new SimpleGoal(goalName, goalDescription, goalPoints));
        }
        else if (newGoalType == 2) // If the user selected Eternal Goal, create a new EternalGoal object and add it to the list
        {
            _goals.Add(new EternalGoal(goalName, goalDescription, goalPoints));
        }
        else if (newGoalType == 3) // If the user selected Checklist Goal, create a new ChecklistGoal object and add it to the list. This Path has more to gather the target and bonus points if completed.
        {
            Console.Write("Enter the target completion count: ");
            int targetCount = 0; // Initialize targetCount variable to test for positive integer and valid input
            try
            {
                targetCount = int.Parse(Console.ReadLine());
                if (targetCount <= 0) // Validate that target count is a positive integer
                {
                    ShowSpinner();
                    Console.Clear();
                    Console.WriteLine("ERROR: Target count must be a positive number.");
                    Pause();
                    return;
                }
            }
            catch (FormatException) // if the input is not a valid integer
            {
                ShowSpinner();
                Console.Clear();
                Console.WriteLine("ERROR: Invalid input for target count, please enter a valid number.");
                Pause();
                return;
            }

            Console.Write("Enter the bonus points for completing the target amount: ");
            int bonusPoints = 0; // Initialize bonusPoints variable to test for positive integer and valid input
            try
            {
                bonusPoints = int.Parse(Console.ReadLine());
                if (bonusPoints < 0) // Validate that bonus points is a non-negative integer
                {
                    ShowSpinner();
                    Console.Clear();
                    Console.WriteLine("ERROR: Bonus points must be a non-negative number.");
                    Pause();
                    return;
                }
            }
            catch (FormatException) // if the input is not a valid integer
            {
                ShowSpinner();
                Console.Clear();
                Console.WriteLine("ERROR: Invalid input for bonus points, please enter a valid number.");
                Pause();
                return;
            }

            _goals.Add(new ChecklistGoal(goalName, goalDescription, goalPoints, targetCount, bonusPoints));
        }

        ShowSpinner();
        Console.Clear();
        Console.WriteLine("Goal created successfully!");
        Pause();
    }
    public void RecordEvent()
    // This method records an event for a specific goal. It adds points to the player's score, tracks progress, and updates the goal's status. 
    // This method is to be used for Option 5
    {
        Console.WriteLine("Goal Checklist");
        Console.WriteLine("--------------------");
        ListGoalNames(); // Display the list of goal names to the user
        if (_goals.Count == 0) // If there are no goals, tell the user and exit the method, which takes you back to the beginning of the while loop
        {
            Console.WriteLine("ERROR: You currently have no goals available to record.");
            Pause(); // Pause the program to allow the user to read the message
            return;
        }

        Console.Write("Which goal did you accomplish? "); // Prompt and read for the goal index for goal event
        int goalIndex;
        if (!int.TryParse(Console.ReadLine(), out goalIndex)) // After attempting to convert the Console.ReadLine to an integer, if it doesnt work, display error. If it does work, goalIndex will be set to the Console.ReadLine value.
        {
            ShowSpinner(); // Show spinner to indicate processing
            Console.Clear(); // Clear the console for a fresh display
            Console.WriteLine("ERROR: Invalid goal selection, please enter a valid number.");
            Pause(); // Pause the program to allow the user to read the error message
            return;
        }
        if (goalIndex < 1 || goalIndex > _goals.Count)
        {
            ShowSpinner(); // Show spinner to indicate processing
            Console.Clear();
            Console.WriteLine("ERROR: Invalid goal selection.");
            Pause();
            return;
        }

        goalIndex = goalIndex - 1; // Adjust for zero-based index

        Goal goal = _goals[goalIndex]; // Get the goal at the specified index

        int basePoints = int.Parse(goal.GetPoints()); // Get the points for the goal
        int pointsEarned = 0; // Initialize points earned

        if (goal is ChecklistGoal checklistGoal) // If the goal is a checklist goal
        {
            int beforeRecord = checklistGoal.GetAmountCompleted(); // Get the amount completed before recording new event
            if (beforeRecord >= checklistGoal.GetTarget()) // If the before and amount completed are equal to the target, the goal is already complete
            {
                Console.WriteLine("This goal is already complete.");
                Pause();
                return;
            }
            else // If the Checklist goal is not complete
            {
                checklistGoal.RecordEvent(); // Record the event for the checklist goal, this adds one to the amount completed
                int afterRecord = checklistGoal.GetAmountCompleted(); // Get the new amount completed after recording

                if (afterRecord > beforeRecord) // If the afterAmount is bigger than the beforeAmount, it means the goal has been progressed. Give the user the points that one event of the goal is worth.
                {
                    Console.WriteLine($"You have completed an event for the goal: {checklistGoal.GetShortName()}");
                    ShowSpinner();
                    pointsEarned += basePoints; // Add base points for each event recorded
                    Console.WriteLine($"Points earned: {checklistGoal.GetPoints()}");
                }

                if (afterRecord == checklistGoal.GetTarget()) // If the afterAmount is equal to the target, that means the goal is now complete. Award them the bonus points associated with the checklist goal.
                {
                    ShowSpinner();
                    Console.WriteLine($"Congratulations! You have completed the goal: {checklistGoal.GetShortName()}");
                    pointsEarned += checklistGoal.GetBonus(); // Add bonus points if the target is reached
                    Console.WriteLine($"Bonus points earned: {checklistGoal.GetBonus()}");
                }
            }
        }
        else if (goal is SimpleGoal simpleGoal) // If the goal is a simple goal
        {
            if (!simpleGoal.IsComplete()) // and if the goal is not complete, that means the goal is now complete, and the user is awarded the points for this goal.
            {
                Console.WriteLine($"You have completed the goal: {simpleGoal.GetShortName()}");
                simpleGoal.RecordEvent();
                pointsEarned += basePoints;
            }
            else // If the goal is already complete, tell user, and exit method which will then take you back to the beginning of the while loop.
            {
                Console.WriteLine("This goal is already complete.");
                Pause();
                return;
            }
        }
        else if (goal is EternalGoal eternalGoal) // If the goal is an eternal goal, because it is always active, we dont have to check for completion. Award points for each event indefinitely.   
        {
            Console.WriteLine($"You have completed an event for the goal: {eternalGoal.GetShortName()}");
            eternalGoal.RecordEvent();
            pointsEarned += basePoints;
        }

        _score += pointsEarned; // Add points earned to total score
        ShowSpinner();
        Console.WriteLine($"Total points earned: {pointsEarned}");
        ShowSpinner();
        Console.WriteLine($"Updated score: {_score}");
        Pause();

    }
    public void SaveGoals()
    // This method saves the current goals and score to a file.
    {
        Console.Write("Enter the filename to save progress: "); // Prompt user for filename
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename)) // Create a StreamWriter to write to the specified file
        {
            writer.WriteLine(_score); // Write the current score to the current line (1), then skip to the next line in the file (2)
            foreach (var goal in _goals) // Iterate through each goal and write its string representation to the file
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        ShowSpinner();
        Console.WriteLine("Goals saved successfully!");
        Pause(); // Pause the program to allow the user to read the message
    }
    public void LoadGoals()
    // This method loads the goals and score from a file.
    {
        Console.Write("Enter the filename to load progress: "); // Prompt user for filename
        string filename = Console.ReadLine();
        _goals.Clear(); // Clear existing goals before loading new ones
        try
        {
            using (StreamReader reader = new StreamReader(filename)) // Create a StreamReader to read from the specified file
            {
                _score = int.Parse(reader.ReadLine()); // Read first line and restore score

                string line = ""; // Initialize a blank string for reading

                while ((line = reader.ReadLine()) != null) // Read line from file, remain in loop while there are lines to read
                {
                    var parts = line.Split('|'); // Split line into parts, and assign parts, then create Goals and add restore them to the goal list.
                    if (parts[0] == "SimpleGoal")
                    {
                        var goal = new SimpleGoal(parts[1], parts[2], parts[3]);
                        _goals.Add(goal);
                        goal.SetIsComplete(bool.Parse(parts[4])); // Restore completion status
                    }
                    else if (parts[0] == "EternalGoal")
                    {
                        var goal = new EternalGoal(parts[1], parts[2], parts[3]);
                        _goals.Add(goal);
                    }
                    else if (parts[0] == "ChecklistGoal")
                    {
                        var goal = new ChecklistGoal(parts[1], parts[2], parts[3], int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]));
                        _goals.Add(goal);

                    }
                }
            }
            ShowSpinner();
            Console.WriteLine("Goals loaded successfully!");
            Pause(); // Pause the program to allow the user to read the message
        }
        catch (FileNotFoundException) // If the file does not exist
        {
            ShowSpinner(); // Show spinner to indicate processing
            Console.Clear(); // Clear the console for a fresh display
            Console.WriteLine("ERROR: File not found. Please check the filename and try again.");
            Pause(); // Pause the program to allow the user to read the message
        }
        catch (FormatException) // if the file format is incorrect
        {
            ShowSpinner();
            Console.Clear();
            Console.WriteLine("ERROR: File format is incorrect or corrupted.");
            Pause();
        }
        catch (Exception ex) // if any other exception occurs
        {
            ShowSpinner();
            Console.Clear();
            Console.WriteLine($"ERROR: Could not load file. Details: {ex.Message}");
            Pause();
        }
    }
    public void ShowSpinner()
    // This method shows a spinner animation in the console to indicate loading or processing.
    {
        string[] frames = { "|", "/", "-", "\\" };
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(3); // Show spinner for 3 seconds
        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(frames[i]);
            Thread.Sleep(250);
            Console.Write("\b"); // Erase the last character
            i = i + 1;
            if (i >= frames.Length)
            {
                i = 0; // Reset index to loop through frames
            }
        }
        ;
    }
    public void DisplayWelcomeMessage()
    // This method displays a welcome message to the player when the game starts. Used in Start() method
    {
        Console.Clear();
        Console.WriteLine("Welcome to Eternal Quest!");
        ShowSpinner();
        Console.Clear();
    }
    public void Pause()
    // This method pauses the game and waits for user input to continue. Used in various parts of the game.
    {
        Console.WriteLine();
        Console.Write("Press Enter to continue...");
        Console.ReadLine();
        Console.Clear();
    }
}