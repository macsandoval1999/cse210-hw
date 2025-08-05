public class BreathingActivity : Activity
{
    // -----MEMBER VARIABLES-----
    //None specific to BreathingActivity

    // -----CONSTRUCTOR-----
    public BreathingActivity()
    // Sets the name, description, and default duration for the Breathing activity.
    // Uses the base class Activity GETTERS and SETTERS to set these properties.
    {
        SetName("Breathing");
        SetDescription("This activity will help you relax by guiding you through slow, deep breaths. Clear your mind and focus on your breathing.");
        SetDuration(60);  // Default duration of 60 seconds
    }

    // -----GETTERS AND SETTERS-----
    // None specific to BreathingActivity

    // -----METHODS-----
    public bool Run()
    // This method runs the Breathing activity
    // It displays the starting message, gets the duration from the user, and then guides the user through a breathing exercise
    // It alternates between breathing in and out for the specified duration
    {

        DisplayStartingMessage();
        try
        {
            SetDuration(int.Parse(Console.ReadLine()));
        }
        catch (FormatException)
        {
            Console.Clear();
            Console.WriteLine("ERROR: Invalid input, please enter a positive number.");
            ShowSpinner(3);
            Console.Clear();
            return false; // Exit the method if input is invalid
        }

        Console.Clear();

        if (GetDuration() <= 0)
        {
            Console.WriteLine("ERROR: Duration must be a positive number.");
            ShowSpinner(3);
            Console.Clear();
            return false; // Exit the method if duration is invalid
        }

        Console.WriteLine("Get ready...");
        ShowSpinner();
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.Write("Breath in... ");
            ShowCountDown();
            Console.Write("Breath out... ");
            ShowCountDown();
            Console.WriteLine();
        }
        DisplayEndingMessage();
        return true; // Return true to indicate the activity was run successfully
    }
}
