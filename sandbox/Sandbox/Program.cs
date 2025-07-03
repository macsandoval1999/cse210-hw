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
        johnsonHome._kitchen._width = 60;
        johnsonHome._kitchen._height = 48;
        johnsonHome._kitchen._color = "White";
        johnsonHome._livingroom._width = 72;
        johnsonHome._livingroom._height = 52;
        johnsonHome._livingroom._color = "white";
        Console.WriteLine($"The {johnsonHome._owner} home has a kitchen blind with an area of {johnsonHome._kitchen.GetArea()} square inches.");
        Console.WriteLine($"The {johnsonHome._owner} home has a living room blind with an area of {johnsonHome._livingroom.GetArea()} square inches.");
        Console.WriteLine("");
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
    public string _owner = "";
    public Blind _kitchen = new Blind();
    public Blind _livingroom = new Blind();
}