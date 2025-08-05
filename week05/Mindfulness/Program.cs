// PROGRAM: Mindfulness Program
// AUTHOR: Marco Sandoval
// DESCRIPTION: This program is a mindfulness application that allows users to engage in three different activities: Breathing, Listing, and Reflecting. It tracks the number of completed activities and the total time spent on them, providing a summary at the end of the session.
//OTHER FILES: BreathingActivity.cs, ListingActivity.cs, ReflectingActivity.cs, Activity.cs
// EXCEEDING EXPECTATIONS: I implemented error handling for the user inputs. I also created trackers for the amount of completed activities a user does, and how long they spent on them. With that, I created a summary at the end of the program that displays the total number of activities completed and the total time spent on them.

using System;
class Program
{
    static void Main(string[] args)
    {
        // Initialize variables to track completed activities and time spent, and set up the main activity instance so we can use its methods.
        int completedActivities = 0; // Total number of completed activities
        int timeSpentOnActivities = 0; // Total duration of all activities
        int choice = 0; // User's menu choice to enter loop
        Activity activity = new Activity(); // Base activity instance for common methods

        // Display timed welcome message with spinner animation
        Console.Clear();
        Console.WriteLine("Welcome to the Mindfulness Program!");
        activity.ShowSpinner(3);
        Console.Clear();

        // Main loop to display the menu and handle user choices
        // The loop continues until the user chooses to quit (option 4)
        while (choice != 4)
        {
            // Display the menu options and get the user's choice
            try
            {
                DisplayMenu();
                choice = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("ERROR: Not a valid option, please enter a number between 1 and 4.");
                activity.ShowSpinner(3);
                Console.Clear();
                continue; // Skip to the next iteration of the loop
            }

            Console.Clear();

            if (choice == 1) // Start the Breathing activity
            {
                // Create an instance of BreathingActivity and run it
                BreathingActivity breathingActivity = new BreathingActivity();
                if (breathingActivity.Run()) // Run and check if the activity was run successfully
                {
                    // If the activity was run successfully, increment completed activities and add the duration to total time spent
                    completedActivities++; // Increment completed activities count
                    timeSpentOnActivities += breathingActivity.GetDuration(); // Add the duration of the breathing activity to total time spent
                }
            }
            else if (choice == 2) // Start the Listing activity
            {
                ListingActivity listingActivity = new ListingActivity();
                if (listingActivity.Run()) // Run and check if the activity was run successfully
                {
                    // Increment completed activities and add the duration of the listing activity to total time spent
                    completedActivities++;
                    timeSpentOnActivities += listingActivity.GetDuration();
                }
            }
            else if (choice == 3) // Start the Reflecting activity
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                // Increment completed activities and add the duration of the reflecting activity to total time spent
                if (reflectingActivity.Run()) // Run and check if the activity was run successfully
                {
                    completedActivities++;
                    timeSpentOnActivities += reflectingActivity.GetDuration();
                }
            }
            else if (choice == 4) // Summarize the program, then Quit the program
            {
                // Display a summary of the activities completed and time spent
                DisplaySummary(completedActivities, timeSpentOnActivities, activity);
            }
            else // Invalid choice
            {
                Console.WriteLine("ERROR: Not a valid option, please enter a number between 1 and 4.");
                activity.ShowSpinner(3);
                Console.Clear();
            }
        }

    }

    // -----METHODS-----
    static void DisplayMenu()
    // Method to display the main menu
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start listing activity");
        Console.WriteLine("3. Start reflecting activity");
        Console.WriteLine("4. Quit");
    }
    static void DisplaySummary(int completedActivities, int timeSpentOnActivities, Activity activity)
    // Method to display a summary of the activities completed and time spent
    {
                Console.WriteLine("Great progress today!");
                activity.ShowSpinner(3);
                Console.WriteLine("In this session...");
                activity.ShowSpinner(3);
                Console.WriteLine();

                Console.WriteLine($"You completed {completedActivities} activities...");
                activity.ShowSpinner(5);
                Console.WriteLine();
                Console.WriteLine($"and spent a total of {timeSpentOnActivities} seconds on your activities...");
                activity.ShowSpinner(5);
                Console.WriteLine();

                Console.WriteLine("Keep up the good work, and remember to make time for yourself!");
                activity.ShowSpinner(5);
                Console.WriteLine("Goodbye!");
                activity.ShowSpinner(3);
                Console.Clear();
    }


}