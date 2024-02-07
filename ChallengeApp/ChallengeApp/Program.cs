using ChallengeApp;

var employee1 = new Employee("Benjamin", "Smith", 41);
var employee2 = new Employee("Susan", "Williams", 35);
var employee3 = new Employee("Liam", "Brown", 23);
var employees = new List<Employee> { employee1, employee2, employee3 };

employee1.AddGrade(10);
employee1.AddGrade(9);
employee1.AddGrade(9);
employee1.AddGrade(10);
employee1.AddGrade(5);

employee2.AddGrade(10);
employee2.AddGrade(9);
employee2.AddGrade(9);
employee2.AddGrade(10);
employee2.AddGrade(8);

employee3.AddGrade(10);
employee3.AddGrade(9);
employee3.AddGrade(9);
employee3.AddGrade(10);
employee3.AddGrade(7);

var employeeWithMaxScore = GetEmployeeWithMaxScore(employees);

Console.WriteLine($"Employee with the highest grade is {employeeWithMaxScore.Name} " +
                  $"{employeeWithMaxScore.Surname} - {employeeWithMaxScore.Result} points");

static Employee GetEmployeeWithMaxScore(List<Employee> employees)
{
    var maxResult = 0;
    Employee employeeWithMaxScore = null!;

    foreach (var employee in employees)
    {
        maxResult = Math.Max(employee.Result, maxResult);
        if (maxResult == employee.Result)
        {
            employeeWithMaxScore = employee;
        }
    }

    return employeeWithMaxScore;
}































//var employeesWithMaxScore = GetEmployeesWithMaxScore(employees);
//foreach (var employeeWithMaxScore in employeesWithMaxScore)
//{
//    Console.WriteLine($"Employee with the highest grade is {employeeWithMaxScore.Name}" +
//                      $"{employeeWithMaxScore.Surname} - {employeeWithMaxScore.Result} points");
//}



static List<Employee> GetEmployeesWithMaxScore(List<Employee> employees)
{
    var maxResult = 0;
    List<Employee> employeesWithMaxScore = new();

    foreach (var employee in employees)
    {
        if (maxResult < employee.Result)
        {
            employeesWithMaxScore = new();
        }
        // maxResult = Math.Max(employee.Result, maxResult);

        employeesWithMaxScore.RemoveAll(x => x.Result < maxResult);

        if (maxResult == employee.Result)
        {
            employeesWithMaxScore.Add(employee);
        }
    }

    return employeesWithMaxScore;
}