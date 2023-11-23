using ChallengeApp;

var employee = new Employee("Benjamin", "Smith");
employee.AddGrade(100);
employee.AddGrade(90);
employee.AddGrade(91);
employee.AddGrade(35);

var statsForEach = employee.GetStatisticsWithForEach();
var statsFor = employee.GetStatisticsWithFor();
var statsDoWhile = employee.GetStatisticsWithDoWhile();
var statsWhile = employee.GetStatisticsWithWihle();

Console.WriteLine("Statistics with foreach:");
Console.WriteLine($"Average: {statsForEach.Average:N2}");
Console.WriteLine($"Min: {statsForEach.Min}");
Console.WriteLine($"Max: {statsForEach.Max}\n");

Console.WriteLine("Statistics with for:");
Console.WriteLine($"Average: {statsFor.Average:N2}");
Console.WriteLine($"Min: {statsFor.Min}");
Console.WriteLine($"Max: {statsFor.Max}\n");

Console.WriteLine("Statistics with do while:");
Console.WriteLine($"Average: {statsDoWhile.Average:N2}");
Console.WriteLine($"Min: {statsDoWhile.Min}");
Console.WriteLine($"Max: {statsDoWhile.Max}\n");

Console.WriteLine("Statistics with while:");
Console.WriteLine($"Average: {statsWhile.Average:N2}");
Console.WriteLine($"Min: {statsWhile.Min}");
Console.WriteLine($"Max: {statsWhile.Max}\n");