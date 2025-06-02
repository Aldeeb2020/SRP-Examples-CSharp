public class Employee
{
    public string Name { get; set; }
    public decimal Salary { get; set; }

    public void SaveEmployee()
    {
        Console.WriteLine($"Saving employee {Name}.");
    }

    public decimal CalculatePayroll()
    {
        Console.WriteLine($"Calculating payroll for {Name}.");
        return Salary * 12;
    }
}
