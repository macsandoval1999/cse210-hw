public abstract class Shape
{
    // -----MEMBER VARIABLES-----
    private string _color;
    // -----CONSTRUCTORS-----
    public Shape(string color)
    {
        _color = color;
    }
    // -----GETTERS AND SETTERS-----
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }
    // -----METHODS-----
    public abstract double GetArea();
}
