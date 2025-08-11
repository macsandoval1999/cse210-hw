public class HourlyEmployee : Employee
{
    // -----MEMBER VARIABLES-----
    private float _hourlyRate = 0; // Default 0
    private float _hoursWorked = 0; // Default 0
    // -----CONSTRUCTORS-----
    public HourlyEmployee(string name, string id, string address, string birthday, float hourlyRate, float hoursWorked)
        : base(name, id, address, birthday)
    {
        _hourlyRate = hourlyRate;
        _hoursWorked = hoursWorked;
    }
    // -----GETTERS AND SETTERS-----
    public float GetHourlyRate()
    {
        return _hourlyRate;
    }
    public void SetHourlyRate(float hourlyRate)
    {
        _hourlyRate = hourlyRate;
    }
    public float GetHoursWorked()
    {
        return _hoursWorked;
    }
    public void SetHoursWorked(float hoursWorked)
    {
        _hoursWorked = hoursWorked;
    }
    // -----METHODS-----
    public override float GetPay() // OVERRIDE keyword tells the compiler that this method is overriding a base class method
    {
        return _hourlyRate * _hoursWorked;
    }
}