using ChallengeApp;

namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void GetStatistics_ReturnsCorrectResult()
        {
            // Arrange
            var employee = new Employee("Lionel", "Messi");
            employee.AddGrade(80);
            employee.AddGrade(90);
            employee.AddGrade(99);
            employee.AddGrade(100);

            // Act
            var stats = employee.GetStatistics();

            // Assert
            Assert.AreEqual(80, stats.Min);
            Assert.AreEqual(100, stats.Max);
            Assert.AreEqual(92.25f, stats.Average);
        }
    }
}