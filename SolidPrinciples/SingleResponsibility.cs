namespace SolidPrinciples;

// Before

// class Employee
// {
//     public string Name { get; set; }
//     public string Surname { get; set; }
//     public string Salary { get; set; }
// 
//     public void PrintTimesheetReport()
//     {
//         // ...
//     }
// }


// After

class Employee
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Salary { get; set; }
}

class TimeSheetReport
{
    public void PrintTimesheetReport(Employee employee)
    {
        // ...
    }
}