public abstract class Activity
{
    // -----MEMBER VARIABLES-----
    // private string _activity; // We could use this, or use the built it method GetType()
    private DateTime _date;
    private int _durationMinutes; // Duration in minutes

    // -----CONSTRUCTORS-----
    public Activity(DateTime date, int durationMinutes)
    {
        _date = date;
        _durationMinutes = durationMinutes;
    }

    // -----GETTERS N SETTERS-----
    public DateTime GetDate()
    {
        return _date;
    }
    public void SetDate(DateTime date)
    {
        _date = date;
    }
    public int GetDuration()
    {
        return _durationMinutes;
    }
    public void SetDuration(int durationMinutes)
    {
        _durationMinutes = durationMinutes;
    }

    // -----METHODS-----
    public virtual string GetSummary()
    // This method will return a summary of the activity. It should be overridden in derived classes to provide a more detailed summary.
    {
        return $"{_date:dd MMM yyyy} ({_durationMinutes} min): ";
    }

    // -----ABSTRACT METHODS-----
    public abstract double GetDistance(); //Get the distance travelled during the activity
    public abstract double GetSpeed(); //Get the average speed per mile during the activity
    public abstract double GetPace(); //Minutes it takes to complete a mile

}
 