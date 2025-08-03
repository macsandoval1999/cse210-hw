using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of Assignment
        Console.WriteLine("Example of Assignment Class:");
        Assignment assignment1 = new Assignment("John Doe", "Math");
        Console.WriteLine($"    {assignment1.GetSummary()}");
        Console.WriteLine();

        // Create an instance of MathAssignment
        Console.WriteLine("Example of MathAssignment Class:");
        MathAssignment mathAssignment1 = new MathAssignment("Jane Smith", "Algebra", "Section 5.2", "Problems 1-10");
        Console.WriteLine($"    {mathAssignment1.GetSummary()}");
        Console.WriteLine($"    {mathAssignment1.GetHomeworkList()}");
        Console.WriteLine();

        Console.WriteLine("Example of MathAssignment Class:");
        // Display homework list for MathAssignment
        MathAssignment mathAssignment2 = new MathAssignment("Hector Garcia", "Calculus");
        Console.WriteLine($"    {mathAssignment2.GetSummary()}");
        Console.WriteLine($"    {mathAssignment2.GetHomeworkList()}");
        Console.WriteLine();

        // Create an instance of WritingAssignment
        Console.WriteLine("Example of WritingAssignment Class:");
        WritingAssignment writingAssignment1 = new WritingAssignment("Alice Johnson", "Shakespeare", "Hamlet");
        Console.WriteLine($"    {writingAssignment1.GetWritingInformation()}");

    }
}