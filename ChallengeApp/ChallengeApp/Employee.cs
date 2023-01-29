﻿namespace ChallengeApp
{
    public class Employee
    {
        private List<int> grades = new();
        public Employee(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public void AddGrade(int grade)
        {
            grades.Add(grade);
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
