using ChallengeApp;

Console.WriteLine("Hello to the Employee Grades App!\n\n");

var employee = new Employee();

while (true)
{
    Console.WriteLine("Please type in employee's grade.\nTo exit and get statistics press 'q'.");
    var input = Console.ReadLine();
    if (input.ToLower() == "q")
    {
        break;
    }
    employee.AddGrade(input);
}

var statistics = employee.GetStatistics();
Console.WriteLine("Employee's :");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Average Letter: {statistics.AverageLetter}");
