using System;

class Program
{
    static void Main(string[] args)
    {
        // Create instances of Fraction using different constructors
        Fraction newFraction = new Fraction();
        Fraction newFraction2 = new Fraction(5);
        Fraction newFraction3 = new Fraction(3, 4);

        // Display the top and bottom numbers of each fraction
        Console.WriteLine(newFraction.GetFractionString() + " = " + newFraction.GetDecimalValue());
        Console.WriteLine(newFraction2.GetFractionString() + " = " + newFraction2.GetDecimalValue());
        Console.WriteLine(newFraction3.GetFractionString() + " = " + newFraction3.GetDecimalValue());

        Console.WriteLine();

        // Display the current top and bottom numbers of the newFraction object
        Console.WriteLine($"{newFraction.GetTopNumber()}/{newFraction.GetBottomNumber()}");
        // Set new values for the top and bottom numbers of the newFraction object
        newFraction.SetTopNumber(5);
        newFraction.SetBottomNumber(10);
        // Display the updated top and bottom numbers of the newFraction object
        Console.WriteLine(newFraction.GetFractionString() + " = " + newFraction.GetDecimalValue());
    }    
}