using System;

class Program
{
    // -----MAIN FUNCTION-----
    // VOID means that a function does not return a value, 
    // so you wouldnt be able to store the result in a variable.
    // STATIC means that the function can be called without creating an instance of the class.
    // MAIN is the entry point of the program.
    // ARGS is an array of strings that can be used to pass arguments to the program.
    // The Main function is where the program starts executing.
    static void Main(string[] args)
    {
        // Display a welcome message.
        DisplayWelcome();

        // Call the function to prompt the user for their name
        // and store the result in a string variable called userName.
        string userName = PromptUserName();

        // Call the function to prompt the user for their number
        // and store the result in a int variable called userNumber.
        int userNumber = PromptUserNumber();

        // Call the function to square the number and store the result
        // in a int variable called numberSquared.
        int numberSquared = SquareNumber(userNumber);

        // Display the result using the user's name and the squared number.
        DisplayResult(userName, numberSquared);
    }


    // ---------------FUNCTIONS---------------



    // This is called to display a welcome message.
    // It does not return any value.
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // This method is called to prompt the user for their name.
    // It returns a string containing the user's name.
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    // This method is called to prompt the user for their number.
    // It returns an integer containing the user's favorite number.
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }

    // This method squares the number.
    // It returns the number squared
    static int SquareNumber(int number)
    {
        int numberSquared = number * number;
        return numberSquared;
    }

    // This method displays the result of the squared number.
    // It takes the user's name and the squared number as parameters.
    // It does not return any value.
    static void DisplayResult(string userName, int numberSquared)
    {
        Console.WriteLine($"Brother {userName}, the square of your number is {numberSquared}.");
    }
}