namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new();

        public Employee()
        {
        }

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
                throw new Exception("Invalid grade!");
            }
        }

        public void AddGrade(int grade)
        {
            var gradeFloat = (float)grade;
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
                throw new Exception("String is not float number.");
            }
        }

        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A' or 'a':
                    this.grades.Add(100);
                    break;
                case 'B' or 'b':
                    this.grades.Add(80);
                    break;
                case 'C' or 'c':
                    this.grades.Add(60);
                    break;
                case 'D' or 'd':
                    this.grades.Add(40);
                    break;
                case 'E' or 'e':
                    this.grades.Add(20);
                    break;
                default:
                    throw new Exception("Wrong letter!");
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

            switch (stats.Average)
            {
                case >= 80:
                    stats.AverageLetter = 'A';
                    break;
                case >= 60:
                    stats.AverageLetter = 'B';
                    break;
                case >= 40:
                    stats.AverageLetter = 'C';
                    break;
                case >= 20:
                    stats.AverageLetter = 'D';
                    break;
                default:
                    stats.AverageLetter = 'E';
                    break;
            }

            return stats;
        }
    }
}
