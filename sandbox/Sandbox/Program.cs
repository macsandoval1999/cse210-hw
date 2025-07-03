using System;
using System.Diagnostics.Contracts;
// ----------CLASSES------------
class Program
{
    static void Main(string[] args)
    {
        Blind kitchen = new Blind();
        kitchen._width = 60;
        kitchen._height = 48;
        kitchen._color = "White";
        double kitchenArea = kitchen.GetArea();
        Console.WriteLine($"The {kitchen._color} blind has an area of {kitchenArea} square inches.");
        Console.WriteLine("");

        House johnsonHome = new House();
        johnsonHome._owner = "Johnson";
        johnsonHome._blinds.Add(kitchen);

        johnsonHome._blinds.Add(new Blind() { _width = 72, _height = 48, _color = "Blue" });
        Console.WriteLine($"{johnsonHome._blinds[1].GetArea()}");
        Console.WriteLine("");

        foreach (Blind b in johnsonHome._blinds)
        {
            double amount = b.GetArea();
            Console.WriteLine($"The {b._color} blind has an area of {amount} square inches.");
        }

    }
}    
public class Blind
{
    public double _width;
    public double _height;
    public string _color;
    public double GetArea()
    {
        return _width * _height;
    }

}
public class House
{
    public string _owner;
    public List<Blind> _blinds = new List<Blind>();
}