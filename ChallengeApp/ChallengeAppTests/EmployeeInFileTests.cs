namespace ChallengeApp.Tests
{
    public class EmployeeInFileTests
    {
        [Test]
        public void GetStatistics_WhenNumbersAreAdded_ReturnsCorrectResult()
        {
            // Arrange
            var employee = new EmployeeInFile("Lionel", "Messi");
            employee.AddGrade(80);
            employee.AddGrade(90);
            employee.AddGrade(99);
            employee.AddGrade(100f);
            employee.AddGrade("70,5");

            // Act
            var stats = employee.GetStatistics();

            // Assert
            Assert.AreEqual(70.5f, stats.Min);
            Assert.AreEqual(100, stats.Max);
            Assert.AreEqual(87.90f, (float)Math.Round(stats.Average, 2));
            Assert.AreEqual('A', stats.AverageLetter);

            DeleteFile();
        }

        [Test]
        public void GetStatistics_WhenLettersAreAdded_ReturnsCorrectResult()
        {
            // Arrange
            var employee = new EmployeeInFile("Lionel", "Messi");
            employee.AddGrade('E');
            employee.AddGrade('C');
            employee.AddGrade('A');

            // Act
            var stats = employee.GetStatistics();

            // Assert
            Assert.AreEqual(20f, stats.Min);
            Assert.AreEqual(100, stats.Max);
            Assert.AreEqual(60.00f, (float)Math.Round(stats.Average, 2));
            Assert.AreEqual('B', stats.AverageLetter);

            DeleteFile();
        }

        private static void DeleteFile()
        {
            var fileName = "grades.txt";
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
        }
    }
}
