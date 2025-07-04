using System;

class Program
{
    static void Main(string[] args)
    {
        // Intro message
        Console.WriteLine("Welcome to the Magic Number Game!");
        // sets variable to allow player to continue playing after each game
        string continueGame = "yes";

        // Loop to allow the player to play multiple games. Game is inside this loop.
        while (continueGame == "yes")
        {
            // Generate a random number between 1 and 100
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);

            // Game instructions
            Console.WriteLine("I have selected a magic number between 1 and 100.");
            Console.WriteLine("Try to guess it!");
            Console.WriteLine("");

            // Initialize variables to keep track of attempts, and to stop looping when correct
            string correct = "no";
            int attempts = 0;

            // Loop to allow the player to guess the magic number as long as they haven't guessed correctly
            while (correct == "no")
            {
                // Increment the number of attempts each time the player makes a guess
                attempts++;
                // Prompt the player for their guess
                Console.WriteLine("What is your guess?");
                // Read the player's guess and convert it to an integer
                int guess = int.Parse(Console.ReadLine());

                // Check if the guess is too low, too high, or correct
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                    Console.WriteLine("");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Congratulations! You guessed the magic number!");
                    Console.WriteLine($"It took you {attempts} attempts to guess the number.");
                    correct = "yes";
                }
            }
            // Ask the player if they want to play again
            Console.WriteLine("Would you like to play again? [yes/no]");
            // Read the player's response assuming they will type "yes" or "no"
            continueGame = Console.ReadLine();
        }
    }
}