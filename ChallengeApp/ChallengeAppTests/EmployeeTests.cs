using ChallengeApp;

namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void GetStatistics_ReturnsCorrectResult()
        {
            // Arrange
            var employee = new EmployeeInMemory("Lionel", "Messi");
            employee.AddGrade(80);
            employee.AddGrade(90);
            employee.AddGrade(99);
            employee.AddGrade(100f);
            employee.AddGrade('E');
            employee.AddGrade("70.5");

            // Act
            var stats = employee.GetStatistics();

            // Assert
            Assert.AreEqual(20f, stats.Min);
            Assert.AreEqual(100, stats.Max);
            Assert.AreEqual(77.80f, (float)Math.Round(stats.Average, 2));
            Assert.AreEqual('B', stats.AverageLetter);
        }
    }
}