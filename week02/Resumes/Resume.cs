using System;
// This is the file for the Resumes project that defines the Resume class.
// 
// RESPONSIBILITIES:
//      - Keeps track of the persons name and a list of their jobs.
// BEHAVIORS:
//      - Displays the resume, which shows the name first, followed by displaying each one of the jobs.

public class Resume
{
    public string _name;
    // This is a list that holds Job instances. It allows the Resume class to keep track of multiple jobs.
    // Because the Job class is defined in the same project, we can use it here.
    public List<Job> _jobs = new List<Job>();
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        // Loop through each 
        // job in the _jobs list
        // The var keyword simply means the compiler will automatically use the correct type for each item in the list.
        foreach (var job in _jobs)
        {
            // Call the Display method defined in the Job class to print the job information.
            job.Display();
        }
    }
}
