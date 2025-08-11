public class Circle : Shape
{
    // -----MEMBER VARIABLES-----
    private double _radius;
    // -----CONSTRUCTORS-----
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }
    // -----GETTERS AND SETTERS-----
    public double GetRadius()
    {
        return _radius;
    }
    public void SetRadius(double radius)
    {
        _radius = radius;
    }
    // -----METHODS-----
    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}