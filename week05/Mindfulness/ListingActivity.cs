public class ListingActivity : Activity
{
    // -----MEMBER VARIABLES-----
    private int _count; // Count of items listed by the user
    private List<string> _prompts = new List<string> // List of prompts for listing positive aspects of life
    {
        "What are some things you are grateful for?",
        "What are some positive experiences you had recently?",
        "Who are some people that make your life better?",
        "What are some skills you are proud of?",
        "What are some goals you are working towards?",
        "What are some lessons you learned recently?",
        "What are some books that inspired you?",
        "What are some hobbies you enjoy?",
        "What are some places you love to visit?",
        "What are some achievements you are proud of?"
    };

    // -----CONSTRUCTOR-----
    public ListingActivity()
    // Sets the name, description, and default duration for the Listing activity.
    // Uses the base class Activity GETTERS and SETTERS to set these properties.
    {
        SetName("Listing");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        SetDuration(60);  // Default duration of 60 seconds
    }

    // -----GETTERS AND SETTERS-----
    public int GetCount()
    {
        return _count;
    }
    public void SetCount(int count)
    {
        _count = count;
    }

    // -----METHODS-----
    public bool Run()
    // This method runs the Listing activity
    // It displays the starting message, gets the duration from the user, and then prompts the user to list items
    // It collects user responses until the duration is reached and then displays the ending message 
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

        Console.WriteLine("List as many responses as you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown();
        Console.WriteLine();
        List<string> userResponses = GetListFromUser();
        SetCount(userResponses.Count); // Update _count with the number of responses
        Console.WriteLine($"You listed {GetCount()} items!");
        Console.WriteLine();
        DisplayEndingMessage();
        return true; // Return true to indicate the activity was run successfully
    }
    public void GetRandomPrompt()
    // This method selects a random prompt from the list and displays it
    // It helps the user to focus on a specific area of gratitude or positivity
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        Console.WriteLine($" --- {prompt} --- ");
    }

    public List<string> GetListFromUser()
    // This method collects a list of user responses based on the prompts
    // It continues to prompt the user until the specified duration is reached
    // It returns a list of strings containing the user's responses and runs for the duration specified by the user
    {
        List<string> responseList = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string userInput = Console.ReadLine();
            responseList.Add(userInput);
        }
        return responseList;
    }
}
