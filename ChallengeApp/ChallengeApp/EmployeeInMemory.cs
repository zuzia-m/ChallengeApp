namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        public override event GradeAddedDelegate GradeAdded;

        private List<float> grades = new();
        public EmployeeInMemory(string name, string surname) : base(name, surname)
        {
        }

        public int GradesCount
        {
            get { return grades.Count; }
        }

        public override void AddGrade(float grade)
        {
            if (grade > 0 && grade <= 100)
            {
                grades.Add(grade);

                if (GradeAdded is not null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception($"Invalid argument: {nameof(grade)}. Only grades from 1 to 100 are allowed!");
            }
        }

        public override Statistics GetStatistics()
        {
            var stats = new Statistics();

            foreach (var grade in this.grades)
            {
                stats.Calculate(grade);
            }

            return stats;
        }
    }
}
