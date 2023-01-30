using Microsoft.VisualBasic;

namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new();
        public Employee(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
            if (grade > 0 && grade <= 100)
            {
                grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid grade!");
            }
        }

        public void AddGrade(int grade)
        {
            var gradeFloat = (float) grade;
            grades.Add(gradeFloat);
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not float number.");
            }
        }

        public Statistics GetStatistics()
        {
            var stats = new Statistics();

            stats.Average = 0;
            stats.Max = float.MinValue;
            stats.Min = float.MaxValue;

            foreach (var grade in grades)
            {
                stats.Max = Math.Max(stats.Max, grade);
                stats.Min = Math.Min(stats.Min, grade);
                stats.Average += grade;
            }

            stats.Average /= grades.Count;

            return stats;
        }
    }
}
