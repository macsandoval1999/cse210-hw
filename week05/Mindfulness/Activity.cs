public class Activity
{
    // -----MEMBER VARIABLES-----
    private string _name;
    private string _description;
    private int _duration;

    // -----CONSTRUCTOR-----
    public Activity()
    {
        _name = "Default Activity";
        _description = "Default Description";
        _duration = 0;
    }

    // -----GETTERS AND SETTERS-----
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    // METHODS
    public void DisplayStartingMessage()
    // This method displays the starting message for the activity
    // It includes the name and description of the activity, and prompts the user for the duration
    {
        Console.WriteLine($"Welcome to the {_name} Activity!");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
    }
    public void DisplayEndingMessage()
    // This method displays a message indicating the activity has ended
    // It also shows a spinner animation and clears the console
    {
        Console.WriteLine("Well done!!!");
        ShowSpinner();
        Console.WriteLine();
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} activity.");
        ShowSpinner();
        Console.Clear();
    }
    public void ShowSpinner(int seconds = 5)
    // This method displays a spinner animation for the specified number of seconds
    // Default is 5 seconds if no argument is provided
    {
        List<string> spinner = new List<string>
        {"|", "/", "-", "\\"}; // Spinner characters representing frames            
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds); // Spinner runs for specified seconds
        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = spinner[i];  // Get the current spinner character
            Console.Write(s); // Print the spinner character
            Thread.Sleep(100); // Pause for 100 milliseconds
            Console.Write("\b \b"); // Clear the last printed character
            i++; // Move to the next index in the spinner
            if (i >= spinner.Count) // If the index exceeds the spinner list size
            {
                i = 0; // Reset index to loop through spinner
            }
        }
    }
    public void ShowCountDown(int seconds = 5)
    // This method displays a countdown from the specified number of seconds
    // Default is 5 seconds if no argument is provided
    {
        Thread.Sleep(1000); // Pause for 1 second before starting the countdown

        // Actual countdown
        for (int i = seconds; i > 0; i--) // Starting at 5, until i = 0, decrementing by 1
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Clear the last printed number
        }
        Console. WriteLine(); // Move to the next line

    }
}