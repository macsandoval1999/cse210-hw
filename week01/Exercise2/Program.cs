using System;

class Program
{
    static void Main(string[] args)
    {
        // Introduction message
        Console.WriteLine("Hello, welcome to Grading Program!");
        // Prompt the user for their score percentage
        Console.Write("Please enter your score percentage: ");
        // Read the input from the user and save into a string variable
        string gradePercentage = Console.ReadLine();
        // Convert the string input to an integer
        int grade = int.Parse(gradePercentage);

        // Initialize the letter grade variable
        string letter = "";
        // -----Determine the letter grade based on the score-----
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Initialize the sign variable
        string sign = "";
        // -----Determine the sign of the grade-----
        // grade % 10 gives the last digit of the grade
        int lastDigit = grade % 10;
        //  This guarantees that the sign cannot be added to A and F grades
        if (lastDigit >= 7 && letter != "F" && letter != "A")
        {
            sign = "+";
        }
        // This guarantees that the sign cannot be added to F grades
        else if (lastDigit <= 3 && letter != "A" && letter != "F")
        {
            sign = "-";
        }
        else if (lastDigit <= 3 && letter != "F")
        {
            sign = "-";
        }
        // If the last digit is between 4 and 6, no sign is added
        else
        {
            sign = "";
        }

        // Initialize the message variable to store the passing or failing message
        string passedMessage = "";
        // -----Check if the grade is passing or failing-----
        // A passing grade is 70 or above
        if (grade >= 70)
        {
            passedMessage = "Congratulations, you passed the course!";
        }
        else
        {
            passedMessage = "Unfortunately, you did not pass the course.";
        }

        // -----Output based on the grade-----
        Console.WriteLine($"Your letter grade is: {letter}{sign}");
        Console.WriteLine(passedMessage);
        Console.WriteLine("Thank you for using the Grading Program!");
    }
}