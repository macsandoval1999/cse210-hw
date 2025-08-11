public class SalaryEmployee : Employee
{
    // -----MEMBER VARIABLES-----
    private float _annualSalary = 0; // Default 0
    // -----CONSTRUCTORS-----
    public SalaryEmployee(string name, string id, string address, string birthday, float annualSalary)
        : base(name, id, address, birthday)
    {
        _annualSalary = annualSalary;
    }
    // -----GETTERS AND SETTERS-----
    public float GetAnnualSalary()
    {
        return _annualSalary;
    }
    public void SetAnnualSalary(float annualSalary)
    {
        _annualSalary = annualSalary;
    }
    // -----METHODS-----
    public override float GetPay()
    {
        return _annualSalary / 12; // Assuming monthly pay
    }
}
