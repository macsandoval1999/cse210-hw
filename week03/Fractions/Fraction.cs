using System;
using System.Runtime.CompilerServices;
public class Fraction
{
    // -----MEMBER VARIABLES-----
    private int _topNumber; // numerator
    private int _bottomNumber; // denominator

    // -----CONSTRUCTORS-----
    // constructor that initializes default values to 1 to avoid division by zero
    public Fraction()
    {
        _topNumber = 1; // Default numerator
        _bottomNumber = 1; // Default denominator
    }
    // constructor that takes one parameter for the numerator
    public Fraction(int topNumber)
    {
        _topNumber = topNumber; // This is the numerator.  _topnumber will be the value in the "int topNumber" parameter.
        _bottomNumber = 1; // default denominator
        // Example topNumber: 5 would create 5/1
    }
    // constructor that takes two parameters for numerator and denominator
    public Fraction(int topNumber, int bottomNumber)
    {
        _topNumber = topNumber; // This is the _topnumber will be the value in the "int topNumber" parameter. 
        _bottomNumber = bottomNumber; // This is the denominator.  _bottomnumber will be the value in the "int bottomNumber" parameter.
    }

    // -----GETTERS AND SETTERS-----
    // Getter to retrieve the top number (numerator) from the fraction object
    public int GetTopNumber()
    {
        return _topNumber;
    }
    public void SetTopNumber(int topNumber)
    {
        _topNumber = topNumber;
    }
    // Getter to retrieve the bottom number (denominator) from the fraction object
    public int GetBottomNumber()
    {
        return _bottomNumber;
    }
    public void SetBottomNumber(int bottomNumber)
    {
        _bottomNumber = bottomNumber;
    }

    // -----METHODS-----
    public string GetFractionString()
    {
        // Returns a string representation of the fraction in the format "top/bottom"
        return $"{_topNumber}/{_bottomNumber}";
    }
    public double GetDecimalValue()
    {
        // Returns the decimal value of the fraction
        return (double)_topNumber / _bottomNumber;
    }
}