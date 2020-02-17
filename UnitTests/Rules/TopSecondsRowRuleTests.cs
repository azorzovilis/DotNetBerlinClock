namespace BerlinClock.UnitTests.Rules
{
    using BerlinClock.Classes.Interfaces;
    using BerlinClock.Classes.Models;
    using BerlinClock.Classes.Models.Rules;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TopSecondsRowRuleTestsTests
    {
        private readonly IRule _itemUnderTest;

        public TopSecondsRowRuleTestsTests()
        {
            _itemUnderTest = new TopSecondsRowRule();
        }

        [TestMethod]
        public void Given_Specific_Hours_Then_Lamp_Light_Should_Be_Off()
        {
            // Arrange
            var seconds = 51;

            // Act
            var result = _itemUnderTest.LampRule(seconds, 1);

            // Assert
            Assert.AreEqual(LampLight.Off, result);
        }

        [TestMethod]
        public void Given_Even_Seconds_Then_Lamp_Light_Should_Be_Yellow()
        {
            // Arrange
            var seconds = 52;

            // Act
            var result = _itemUnderTest.LampRule(seconds, 1);

            // Assert
            Assert.AreEqual(LampLight.Yellow, result);
        }
    }
}
