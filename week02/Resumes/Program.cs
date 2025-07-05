using System;
// This is the file for the Resumes project that contains the main entry point of the application.
class Program
{
    // The line static void Main(string[] args) defines the main entry point of a C# console application. Here’s what each part means:
    // -    static:  This means the method belongs to the class itself, not to any specific object. The runtime can call it without creating an instance of the class.
    // -    void:    This means the method does not return any value.
    // -    Main:    This is the special method name that the C# runtime looks for when starting the program.
    // -    string[] args:   This is an array of strings that holds any command-line arguments passed to the program when it is started.
    static void Main(string[] args)
    {
        // Create a Job type variable called job1, which is a new instance of the Job class.
        Job job1 = new Job();
        // Access the properties defined by the class Job to set the company, job title, start year, and end year for the instance job1
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._company = "Google";
        job2._jobTitle = "Data Scientist";
        job2._startYear = 2020;
        job2._endYear = 2023;

        // Create a Resume type variable called resume1, which is a new instance of the Resume class.
        Resume resume1 = new Resume();
        // Access the properties defined by the class Resume to set the name and add jobs to the resume.
        resume1._name = "Marco Sandoval";
        // Add the job1 and job2 instances to the list of jobs in resume1.
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        // Access resume1, and then access the job found in index 0 which is job1 in the list of jobs for resume1, and then access the job title property to change it to "Senior Software Engineer". 
        resume1._jobs[0]._jobTitle = "Senior Software Engineer";
        // Call the Display method defind in the Resume class to print the resume information to the console.
        resume1.Display();
    }
}