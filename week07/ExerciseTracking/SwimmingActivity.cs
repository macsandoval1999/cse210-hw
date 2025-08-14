public class SwimmingActivity : Activity
{
    private double _laps;

    public SwimmingActivity(DateTime date, int durationMinutes, double laps) : base(date, durationMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    // distance travelled in miles is laps * 50 meters/lap * 0.000621371 miles/meter
    {
        double distance = _laps * 50 / 1000 * 0.62;
        return distance;
    }

    public override double GetSpeed()
    // distance is miles/hour, duration is minutes so divide by 60 to convert to hours
    {
        double speed = GetDistance() / (GetDuration() / 60.0);
        return speed;
    }

    public override double GetPace()
    // pace in minutes per mile
    {
        double pace = GetDuration() / GetDistance();
        return pace;
    }

    public override string GetSummary()
    // Updated summary for SwimmingActivity
    {
        return $"{base.GetSummary()} Laps {_laps}, Distance {GetDistance():F2} miles, Speed {GetSpeed():F2} mph, Pace {GetPace():F2} min per mile";
    }
}