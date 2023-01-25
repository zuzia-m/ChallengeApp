using ChallengeApp;

namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeCollectsTwoGrades_ShouldReturnCorrectResult()
        {
            // Arrange
            var employee = new Employee("Lionel", "Messi", 35);
            employee.AddGrade(10);
            employee.AddGrade(9);

            // Act
            var result = employee.Result;
            
            // Assert
            Assert.AreEqual(19, result);
        }

        [Test]
        public void WhenEmployeeCollectsScoreEqualZero_ResultShoudBeZero()
        {
            // Arrange
            var employee = new Employee("Lionel", "Messi", 35);
            employee.AddGrade(10);
            employee.AddGrade(9);
            employee.AddGrade(-9);
            employee.AddGrade(-10);

            // Act
            var result = employee.Result;

            // Assert
            Assert.AreEqual(0, result);
        }
    }
}