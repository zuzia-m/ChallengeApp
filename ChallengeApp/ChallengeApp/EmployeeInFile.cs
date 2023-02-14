using System.Diagnostics;
using System.IO.Enumeration;
using System.Numerics;

namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";
        public EmployeeInFile(string name, string surname) : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade > 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
            }
            else
            {
                throw new ArgumentException($"Invalid argument: {nameof(grade)}. Only grades from 1 to 100 are allowed!");
            }
        }

        public override void AddGrade(string grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(char grade)
        {
            throw new NotImplementedException();
        }

        public override Statistics GetStatistics()
        {
            var stats = new Statistics();

            if (File.Exists(fileName))
            {
                stats.Average = 0;
                stats.Max = float.MinValue;
                stats.Min = float.MaxValue;
                int count = 0;

                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var grade = float.Parse(line);
                        stats.Max = Math.Max(stats.Max, grade);
                        stats.Min = Math.Min(stats.Min, grade);
                        stats.Average += grade;
                        count++;
                        line = reader.ReadLine();
                    }
                }
                stats.Average /= count;

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
            }

            return stats;
        }
    }
}
