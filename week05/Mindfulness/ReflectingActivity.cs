public class ReflectingActivity : Activity
{
    // -----MEMBER VARIABLES-----
    private List<string> _prompts = new List<string> // List of prompts for reflection
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
        "Think of a time when you learned something new about yourself.",
        "Think of a time when you overcame a challenge.",
        "Think of a time when you made a positive impact on someone else's life.",
        "Think of a time when you felt truly happy.",
        "Think of a time when you felt proud of yourself.",
        "Think of a time when you learned from a mistake."
    };
    private List<string> _questions = new List<string> // List of questions to ponder after reflecting on the prompt
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    // -----CONSTRUCTOR-----
    public ReflectingActivity()
    // Sets the name, description, and default duration for the Reflecting activity.
    // Uses the base class Activity GETTERS and SETTERS to set these properties.
    {
        SetName("Reflecting");
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        SetDuration(60);  // Default duration of 60 seconds
    }

    // -----GETTERS AND SETTERS-----
    // None specific to ReflectingActivity

    // -----METHODS-----
    public bool Run()
    // This method runs the Reflecting activity
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

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        DisplayPrompt();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        DisplayQuestions();
        Console.WriteLine();
        DisplayEndingMessage();
        return true; // Return true to indicate the activity was run successfully
    }
    public string GetRandomPrompt()
    // This method returns a random prompt from the list of prompts
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
    public string GetRandomQuestion()
    // This method returns a random question from the list of questions
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }
    public void DisplayPrompt()
    // This method displays a random prompt to the user
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($" --- {prompt} --- ");
    }
    public void DisplayQuestions()
    // This method displays a series of questions for the user to ponder
    // It prompts the user to think deeply about their experiences related to the prompt
    // It uses a spinner to indicate the time for reflection and runs for the duration specified by the user
    {
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown();
        Console.Clear();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        while (DateTime.Now < endTime) // While the duration is not yet reached
        {
            Console.Write($"> {GetRandomQuestion()} ");
            ShowSpinner(10); // Show spinner for 10 seconds for each question
            Console.WriteLine(); 
        }

    }
}