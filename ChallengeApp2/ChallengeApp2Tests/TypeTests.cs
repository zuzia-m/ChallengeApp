namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void TwoStringsAreEqual()
        {
            var string1 = "tralalala";
            var string2 = "tralalala";

            Assert.AreEqual(string1, string2);
        }

        [Test]
        public void TwoCharsAreEqual()
        {
            var char1 = 'o';
            var char2 = 'o';

            Assert.AreEqual(char1, char2);
        }

        [Test]
        public void TwoSameIntsAreEqual()
        {
            var number1 = 1;
            var number2 = 1;

            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void GetEmployeeReturnsDifferentObjects()
        {
            var emp1 = GetEmployee("Lionel", "Messi");
            var emp2 = GetEmployee("Luis", "Suarez");

            Assert.AreNotEqual(emp1, emp2);
        }

        private Employee GetEmployee(string name, string surname)
        {
            return new Employee(name, surname);
        }
    }
}
