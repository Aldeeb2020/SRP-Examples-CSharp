public class Employee
{
    public string Name { get; set; }
    public decimal Salary { get; set; }

    public void SaveEmployee()
    {
        Console.WriteLine($"Saving employee {Name}.");
    }
}

public class PayrollService
{
    public decimal CalculatePayroll(Employee employee)
    {
        Console.WriteLine($"Calculating payroll for {employee.Name}.");
        return employee.Salary * 12;
    }
}
