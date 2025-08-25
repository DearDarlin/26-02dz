using System;
using System.Linq;

public record Employee(string FirstName, string LastName, int Salary) {
    public int CompareSalary(Employee other)
    {
        return this.Salary.CompareTo(other.Salary);
    }
}


class Program
{
    static void Main(string[] args)
    {
        Employee[] employees = new Employee[]
        {
            new Employee("John", "Doe", 50000),
            new Employee("Jane", "Smith", 60000),
            new Employee("Darina", "Kovalenko", 550000)
        };
        var sortedEmployees = employees.OrderBy(e => e, Comparer<Employee>.Create((a, b) => a.CompareSalary(b)));
        foreach (var emp in sortedEmployees)
        {
            Console.WriteLine($"{emp.FirstName} {emp.LastName}: {emp.Salary}");
        }

        Console.WriteLine($"Max Salary: {employees.Max(e => e.Salary)}");
        Console.WriteLine($"Min Salary: {employees.Min(e => e.Salary)}");
    }
}