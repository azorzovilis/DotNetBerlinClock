namespace BerlinClock.UnitTests
{
    using BerlinClock.Classes;
    using BerlinClock.Classes.Interfaces;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TimeValidatorTests
    {
        private readonly ITimeValidator _itemUnderTest;

        public TimeValidatorTests()
        {
            _itemUnderTest = new TimeValidator();
        }

        [TestMethod]
        public void Given_Invalid_Input_Then_Result_Should_Return_False()
        {
            // Arrange
            var aTime = "11:00";

            // Act
            var result = _itemUnderTest.IsValidTime(aTime);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Given_More_Than_24_Hours_Then_Result_Should_Return_False()
        {
            // Arrange
            var aTime = "25:00:00";

            // Act
            var result = _itemUnderTest.IsValidTime(aTime);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Given_Valid_Input_Then_Validation_Should_Return_True()
        {
            // Arrange
            var aTime = "21:52:14";

            // Act
            var result = _itemUnderTest.IsValidTime(aTime);

            // Assert
            Assert.IsTrue(result);
        }
    }
}
