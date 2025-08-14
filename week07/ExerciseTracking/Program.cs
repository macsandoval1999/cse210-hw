//////////////////////////////////////
// Program: Exercise Tracking
// Author: Marco Sandoval
// Description: This program tracks different types of exercise activities.

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of activities
        List<Activity> activities = new List<Activity>();

        // Create instances of each activity type
        RunningActivity run = new RunningActivity(new DateTime(2025, 8, 13), 30, 3);
        CyclingActivity cycle = new CyclingActivity(new DateTime(2025, 8, 14), 45, 5);
        SwimmingActivity swim = new SwimmingActivity(new DateTime(2025, 8, 15), 30, 10);

        // Add activities to the list
        activities.Add(run);
        activities.Add(cycle);
        activities.Add(swim);

        // Display summaries for all activities
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}
