using System;
class Program
{
    static void Main(string[] args)
    {
        HourlyEmployee hourlyEmployee = new HourlyEmployee("John Doe", "123", "123 Main St", "01/01/1990", 20.0f, 40.0f);
        SalaryEmployee salaryEmployee = new SalaryEmployee("Jane Smith", "456", "456 Elm St", "02/02/1992", 60000.0f);
        DisplayEmployeeDetails(hourlyEmployee);
        DisplayEmployeeDetails(salaryEmployee);

    }
    static void DisplayEmployeeDetails(Employee employee)
    {
        Console.WriteLine($"Name: {employee.GetName()}");
        Console.WriteLine($"ID: {employee.GetId()}");
        Console.WriteLine($"Address: {employee.GetAddress()}");
        Console.WriteLine($"Birthday: {employee.GetBirthday()}");
        Console.WriteLine($"Pay: {employee.GetPay()}");
    }
}
