namespace BerlinClockTests.UnitTests
{
    using BerlinClock.Classes;
    using BerlinClock.Classes.Interfaces;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;
    using System;

    [TestClass]
    public class BerlinClockContextTests
    {
        private IBerlinClockContext _itemUnderTest;
        private readonly IBerlinClockFactory _berlinClockFactory = Mock.Of<IBerlinClockFactory>();

        private class FakeClock : IClock {
            internal FakeClock() { }
        }

        [TestMethod]
        public void Given_A_New_Context_When_Then_A_Default_Berlin_Clock_Should_Be_Returned()
        {
            // Arrange
            var defaultTime = TimeSpan.Zero;
            var clock = new FakeClock();

            Mock.Get(_berlinClockFactory).Setup(s => s.GenerateBerlinClock(defaultTime)).Returns(clock);
            _itemUnderTest = new BerlinClockContext(_berlinClockFactory);

            // Act
            var result = _itemUnderTest.GetBerlinClock();

            // Assert
            Assert.IsNotNull(result);
            Mock.Get(_berlinClockFactory).Verify(s => s.GenerateBerlinClock(defaultTime), Times.Once());
        }
    }
}
