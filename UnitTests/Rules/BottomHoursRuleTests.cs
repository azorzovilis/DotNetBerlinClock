namespace BerlinClock.UnitTests.Rules
{
    using BerlinClock.Classes.Interfaces;
    using BerlinClock.Classes.Models;
    using BerlinClock.Classes.Models.Rules;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class BottomHoursRuleTests
    {
        private IRule _itemUnderTest;

        public BottomHoursRuleTests()
        {
            _itemUnderTest = new BottomHoursRule();
        }

        [TestMethod]
        [DataRow(0, 0)]
        [DataRow(5, 0)]
        [DataRow(10, 0)]
        [DataRow(15, 0)]
        [DataRow(20, 0)]
        [DataRow(0, 1)]
        [DataRow(5, 1)]
        [DataRow(10, 1)]
        [DataRow(15, 1)]
        [DataRow(20, 1)]
        [DataRow(0, 2)]
        [DataRow(5, 2)]
        [DataRow(10, 2)]
        [DataRow(15, 2)]
        [DataRow(20, 2)]
        [DataRow(0, 3)]
        [DataRow(5, 3)]
        [DataRow(10, 3)]
        [DataRow(15, 3)]
        [DataRow(20, 3)]
        //TODO: Add missing test cases
        public void Given_Specific_Hours_And_Lamp_Index_Then_Lamp_Light_Should_Be_Off(int hours, int lampIndex)
        {
            // Act
            var result = _itemUnderTest.LampRule(hours, lampIndex);

            // Assert
            Assert.AreEqual(LampLight.Off, result);
        }

        [TestMethod]
        [DataRow(1, 0)]
        [DataRow(2, 0)]
        [DataRow(3, 0)]
        [DataRow(4, 0)]
        [DataRow(6, 0)]
        [DataRow(7, 0)]
        [DataRow(8, 0)]
        [DataRow(9, 0)]
        [DataRow(11, 0)]
        [DataRow(12, 0)]
        [DataRow(13, 0)]
        [DataRow(14, 0)]
        [DataRow(16, 0)]
        [DataRow(17, 0)]
        [DataRow(18, 0)]
        [DataRow(19, 0)]
        [DataRow(21, 0)]
        [DataRow(22, 0)]
        [DataRow(23, 0)]
        [DataRow(24, 0)]
        [DataRow(2, 1)]
        [DataRow(3, 1)]
        [DataRow(4, 1)]
        [DataRow(7, 1)]
        [DataRow(8, 1)]
        [DataRow(9, 1)]
        [DataRow(12, 1)]
        [DataRow(13, 1)]
        [DataRow(14, 1)]
        [DataRow(17, 1)]
        [DataRow(18, 1)]
        [DataRow(19, 1)]
        [DataRow(22, 1)]
        [DataRow(23, 1)]
        [DataRow(24, 1)]
        [DataRow(3, 2)]
        [DataRow(4, 2)]
        [DataRow(8, 2)]
        [DataRow(9, 2)]
        [DataRow(13, 2)]
        [DataRow(14, 2)]
        [DataRow(18, 2)]
        [DataRow(19, 2)]
        [DataRow(23, 2)]
        [DataRow(24, 2)]
        [DataRow(4, 3)]
        [DataRow(9, 3)]
        [DataRow(14, 3)]
        [DataRow(19, 3)]
        [DataRow(24, 3)]
        public void Given_Specific_Hours_And_Lamp_Index_Then_Lamp_Light_Should_Be_Red(int hours, int lampIndex)
        {
            // Act
            var result = _itemUnderTest.LampRule(hours, lampIndex);

            // Assert
            Assert.AreEqual(LampLight.Red, result);
        }
    }
}
