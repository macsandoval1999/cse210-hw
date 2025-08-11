public class Square : Shape
{
    // -----MEMBER VARIABLES-----
    private double _side;
    // -----CONSTRUCTORS-----
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }
    // -----GETTERS AND SETTERS-----
    public double GetSide()
    {
        return _side;
    }
    public void SetSide(double side)
    {
        _side = side;
    }
    // -----METHODS-----
    public override double GetArea()
    {
        return _side * _side;
    }
}