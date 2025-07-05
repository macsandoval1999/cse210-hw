using System;
// This is the file for the Resumes project that defines the Job class.
// 
// RESPONSIBILITIES:
//      - Keeps track of the company, job title, start year, and end year.
// BEHAVIORS:
//      - Displays the job information in the format:
//        "Job Title (Company) StartYear-EndYear"
//      - Example:
//      - "Software Engineer (Microsoft) 2019-2022"

// public means the class is accessible outside of this file.
// class means this is a class definition.
// Job is the name of the class.
public class Job
{
    // These are the properties of the Job class.
    // public means these properties can be accessed outside of this class.
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;
    // This method displays the job information in a formatted string.
    // The method is public, meaning it can be called from outside this class.
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
