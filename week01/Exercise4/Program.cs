using System;

class Program
{
    static void Main(string[] args)
    {
        // -----Create a list of numbers-----
        // This makes a new list of integers called numbers
        List<int> numbers = new List<int>();
        // Prompt the user to enter numbers until they enter 0
        Console.WriteLine("Enter a list of numbers, type 0 when finished:");
        // Initialize a variable to enter the loop
        int newNumber = 1;
        while (newNumber != 0)
        {
            // Prompt the user to enter a number
            Console.Write("Enter number: ");
            // Read the number from the console, convert it and add it to the list
            newNumber = int.Parse(Console.ReadLine());
            // If the number is 0, break the loop; otherwise, add it to the list
            if (newNumber == 0)
            {
                break;
            }
            else
            {
                numbers.Add(newNumber);
            }
        }
        Console.WriteLine("");

        // -----Print the numbers in the list-----
        Console.WriteLine("The numbers in the list are:");
        // Iterate through each number in the list and print it
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine("");

        // -----Compute the sum of the numbers in the list-----
        // Initialize a variable to hold the sum of the numbers
        int sum = 0;
        // Iterate through each number in the list and add it to the sum
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum of the numbers is: {sum}");
        Console.WriteLine("");

        // -----Compute the average of the numbers in the list-----
        // Calculate the average by dividing the sum by the count of numbers
        float average = (float)sum / numbers.Count;
        Console.WriteLine($"The average of the numbers is: {average}");
        Console.WriteLine("");

        // -----Find the largest number in the list-----
        // Initialize a variable to hold the largest number, starting with the first number in the list
        int largest = numbers[0];
        // Iterate through each number and compare it to previous large number
        foreach (int number in numbers)
        {
            // If the current number is larger than the largest found so far, update largest
            if (number > largest)
            {
                largest = number;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine("");

        // -----Find the smallest positive number in the list-----
        // Initialize a variable to hold the smallest number, starting with the first number in the list
        int smallest = numbers[0];
        // Iterate through each number and compare it to previous smallest positive number
        foreach (int number in numbers)
        {
            // If the current number is smaller than the smallest found so far and greater than 0, update smallest
            if (number < smallest && number > 0)
            {
                smallest = number;
            }
        }
        Console.WriteLine($"The smallest number is: {smallest}");
        Console.WriteLine("");

        // -----Create a sorted list of numbers-----
        // Create a new list called sortedNumbers and copy the contents of numbers into it
        List<int> sortedNumbers = new List<int>(numbers);
        // Sort the list of numbers
        // This uses the built-in Sort method to sort the numbers in ascending order
        sortedNumbers.Sort();
        Console.WriteLine("The sorted list of numbers is:");
        // Iterate through each number in the sorted list and print it
        foreach (int number in sortedNumbers)
        {
            Console.WriteLine(number);
        }
    }
}