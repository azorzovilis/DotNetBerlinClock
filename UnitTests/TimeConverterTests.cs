namespace BerlinClockTests.UnitTests
{
    using BerlinClock.Classes;
    using BerlinClock.Classes.Interfaces;
    using BerlinClock.Classes.Models;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;
    using System;

    [TestClass]
    public class TimeConverterTests
    {
        private readonly ITimeConverter _itemUnderTest;
        private readonly IBerlinClockContext _berlinClockContext = Mock.Of<IBerlinClockContext>();
        private readonly ITimeValidator _timeValidator = Mock.Of<ITimeValidator>();

        public TimeConverterTests()
        {
            _itemUnderTest = new TimeConverter(_berlinClockContext, _timeValidator);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Given_Invalid_Time_Then_An_Argument_Exception_Should_Be_Thrown()
        {
            // Arrange
            var aTime = "28:00:02";
            Mock.Get(_timeValidator).Setup(s => s.IsValidTime(aTime)).Returns(false);

            // Act
            _itemUnderTest.ConvertTime(aTime);

            // Assert
            // Expected exception
        }

        [TestMethod]
        public void Given_A_Valid_Time_Then_The_Berlin_Clock_Should_Be_Set_And_A_String_Should_Be_Returned()
        {
            // Arrange
            var time = new TimeSpan(23, 33, 18);
            var clock = new Clock();

            Mock.Get(_timeValidator).Setup(s => s.IsValidTime(time.ToString())).Returns(true);      
            Mock.Get(_berlinClockContext).Setup(s => s.SetBerlinClockTime(time)).Returns(clock);
            Mock.Get(_berlinClockContext).Setup(s => s.GetBerlinClock()).Returns(clock);

            // Act
            var result = _itemUnderTest.ConvertTime(time.ToString());

            // Assert
            Assert.IsNotNull(result);
            Mock.Get(_timeValidator).Verify(s => s.IsValidTime(time.ToString()), Times.Once());
            Mock.Get(_berlinClockContext).Verify(s => s.SetBerlinClockTime(time), Times.Once());
            Mock.Get(_berlinClockContext).Verify(s => s.GetBerlinClock(), Times.Once());
        }
    }
}
