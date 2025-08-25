using System;
using System.Linq;

public record StudentGrades(string Name, int[] Grades);

class Program
{
    static void Main()
    {
        var students = new[]
        {
            new StudentGrades("Mark", new[] { 12, 9, 7 }),
            new StudentGrades("Bob", new[] { 6, 2, 9 }),
            new StudentGrades("Darina", new[] { 12, 11, 12 })
        };
        var averageGrades = students
            .Select(s => new
            {
                s.Name,
                AverageGrade = s.Grades.Average()
            });
        foreach (var student in averageGrades)
        {
            Console.WriteLine($"{student.Name}: {student.AverageGrade:F2}");
        }

        Console.WriteLine($"Student with highest average: {averageGrades.OrderByDescending(s => s.AverageGrade).First().Name}");
    }
}