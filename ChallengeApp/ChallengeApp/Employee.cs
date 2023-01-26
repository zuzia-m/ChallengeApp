namespace ChallengeApp
{
    public class Employee
    {
        private List<int> grades = new();
        public Employee(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public string City { get; private set; }

        public int Result
        {
            get
            {
                return grades.Sum();
            }
        }

        public void AddGrade(int grade)
        {
            grades.Add(grade);
        }
    }
}
