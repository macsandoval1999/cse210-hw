public class CyclingActivity : Activity
{
    // -----MEMBER VARIABLES-----
    private double _speed; // Speed in miles per hour

    // -----CONSTRUCTORS-----
    public CyclingActivity(DateTime date, int durationMinutes, double speed) : base(date, durationMinutes)
    {
        _speed = speed;
    }

    // -----GETTERS N SETTERS-----
    public override double GetSpeed()
    {
        return _speed;
    }
    public void SetSpeed(double speed)
    {
        _speed = speed;
    }

    // -----METHODS-----
    public override double GetDistance()
    // distance travelled. speed is in mph, duration is in minutes so multiply times 60 for hours to get accurate distance
    {
        double distance = GetSpeed() * GetDuration() / 60.0; // Convert duration to hours
        return distance;
    }
    public override double GetPace()
    // pace in minutes per mile
    {
        double pace = 60 / GetSpeed();
        // double pace = GetDuration() / GetDistance(); // This also works
        return pace;
    }
    public override string GetSummary()
    // updated summary for CyclingActivity
    {
        return $"{base.GetSummary()} Distance {GetDistance():F2} miles, Speed {GetSpeed():F2} mph, Pace {GetPace():F2} min per mile";
    }
}
