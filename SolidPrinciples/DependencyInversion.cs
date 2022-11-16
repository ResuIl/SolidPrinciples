namespace SolidPrinciples;

// Before

// class SalaryCalculator
// {
//     public float CalculateSalary(int hoursWorked, float hourlyRate) => hoursWorked * hourlyRate;
// }
// 
// class EmployeeDetails
// {
//     public int HoursWorked { get; set; }
//     public int HourlyRate { get; set; }
// 
//     public float GetSalary() => new SalaryCalculator().CalculateSalary(HoursWorked, HourlyRate);
// }

// After

public interface ISalaryCalculator
{
    float CalculateSalary(int hoursWorked, float hourlyRate);
}

public class SalaryCalculatorModified : ISalaryCalculator
{
    public float CalculateSalary(int hoursWorked, float hourlyRate) => hoursWorked * hourlyRate;
}

public class EmployeeDetailsModified
{
    private readonly ISalaryCalculator _salaryCalculator;

    public int HoursWorked { get; set; }
    public int HourlyRate { get; set; }

    public EmployeeDetailsModified(ISalaryCalculator salaryCalculator) => _salaryCalculator = salaryCalculator;

    public float GetSalary() => _salaryCalculator.CalculateSalary(HoursWorked, HourlyRate);
}