using ChallengeApp;

Console.WriteLine("Hello to the Employee Grades App!\n\n");
Console.WriteLine("Test test test");
Console.WriteLine("Type in Employee's name:");
var name = Console.ReadLine()!;
Console.WriteLine("Type in Employee's surname:");
var surname = Console.ReadLine()!;

Console.WriteLine("Test");

var employee = new EmployeeInFile(name, surname);
employee.GradeAdded += EmployeeGradeAdded;

while (true)
{
    Console.WriteLine($"Please type in {employee.Name} {employee.Surname} grade.\nTo exit and get statistics press 'q'.");
    var input = Console.ReadLine()!;
    if (input.ToLower() == "q")
    {
        break;
    }

    try
    {
        employee.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched! {e.Message}");
    }
}

if (employee.GradesCount > 0)
{
    var statistics = employee.GetStatistics();
    Console.WriteLine("Statistics:");
    Console.WriteLine($"Average: {statistics.Average:N2}");
    Console.WriteLine($"Min: {statistics.Min}");
    Console.WriteLine($"Max: {statistics.Max}");
    Console.WriteLine($"Average Letter: {statistics.AverageLetter}");
}


void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Grade added.");
}