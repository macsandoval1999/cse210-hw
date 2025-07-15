using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Create a List called people which will hold Person objects. It will call the LoadFromFile function and return a List of Person objects.
        List<Person> people = LoadFromFile();
        
        // Print the details of each person object in the people list
        foreach (Person person in people)
        {
            Console.WriteLine($"Name: {person._firstName} {person._lastName}, Age: {person._age}");
        }

        // Call the SaveToFile function, passing the people list as an argument
        // SaveToFile(people);
        // Console.WriteLine("Saving people to file...");
        // Console.WriteLine();

        // Console.WriteLine("Press any key to continue...");
        // Console.ReadKey();
        // Console.WriteLine();

        // Console.WriteLine("People saved to file.");

    }

    // ----------FUNCTIONS-----------

    // Function to save the people list to a file. It requires a List of Person objects as an argument.
    public static void SaveToFile(List<Person> people)
    {
        // user is prompted to enter the filename to save the people to
        Console.WriteLine("What file would you like to save the people to?");
        string filename = Console.ReadLine();
        // A StreamWriter variable is created to write to the specified file. using statement ensures that the file is properly closed after writing.
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // Loop through each Person object in the people list
            foreach (Person person in people)
            {
                // In the outputFile, Write the person's details to the file in CSV format: "FirstName,LastName,Age", then skip to the next line.
                outputFile.WriteLine($"{person._firstName},{person._lastName},{person._age}");
            }
        }
    }

    // Function to load the people list from a file. It does not require any arguments and returns a List of Person objects.
    public static List<Person> LoadFromFile()
    {
        // user is prompted to enter the filename to load the people from
        Console.WriteLine("What file would you like to load the people from?");
        string filename = Console.ReadLine();
        Console.WriteLine("Loading people from file...");
        // a new List of Person objects is created
        List<Person> people = new List<Person>();
        // Create an array of strings to hold the lines read from the file. Each line will look like this: "John,Doe,30"
        string[] lines = System.IO.File.ReadAllLines(filename);
        // Loop through each line in the lines string array
        foreach (string line in lines)
        {
            // Split the line into parts using comma as the delimiter. Each part will look like this: parts[0] = "John", parts[1] = "Doe", parts[2] = "30"
            string[] parts = line.Split(',');
            // Create a new Person object and assign the values from the parts array to the corresponding properties of the Person object
            Person newPerson = new Person();
            newPerson._firstName = parts[0].Trim();
            newPerson._lastName = parts[1].Trim();
            // Convert the age from string to int and assign it to the _age property of the Person object
            newPerson._age = int.Parse(parts[2].Trim());
            // Once the Person object is completed, it is added to the people list
            people.Add(newPerson);
        }
        return people;
    }
}
