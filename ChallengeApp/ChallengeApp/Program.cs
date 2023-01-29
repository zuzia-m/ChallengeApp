using ChallengeApp;

var employee = new Employee("Benjamin", "Smith");
employee.AddGrade(100);
employee.AddGrade(90);
employee.AddGrade(91);
employee.AddGrade(35);
var stats = employee.GetStatistics();

Console.WriteLine($"Average: {stats.Average:N2}");
Console.WriteLine($"Min: {stats.Min}");
Console.WriteLine($"Max: {stats.Max}");
