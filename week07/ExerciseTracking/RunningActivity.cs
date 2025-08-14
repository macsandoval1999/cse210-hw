public class RunningActivity : Activity
{
    // -----MEMBER VARIABLES-----
    private double _distanceMiles; // Distance in miles

    // -----CONSTRUCTORS-----
    public RunningActivity(DateTime date, int durationMinutes, double distanceMiles) : base(date, durationMinutes)
    {
        _distanceMiles = distanceMiles;
    }

    // -----GETTERS N SETTERS-----
    public override double GetDistance()
    {
        return _distanceMiles;
    }
    public void SetDistance(double distanceMiles)
    {
        _distanceMiles = distanceMiles;
    }

    // -----METHODS-----
    public override double GetSpeed()
    // Speed in mph or MILES/HOUR(converted into minutes)
    {
        double speed = GetDistance() / GetDuration() * 60;
        return speed;
    }
    public override double GetPace()
    // Pace in minutes per mile
    {
        double pace = 60 / GetSpeed();
        // double pace = GetDuration() / GetDistance(); // This also works
        return pace;
    }
    public override string GetSummary()
    // Updated Summary for RunningActivity
    {
        return $"{base.GetSummary()} Distance {GetDistance():F2}, miles, Speed {GetSpeed():F2} mph, Pace {GetPace():F2} min per mile";
    }
}
