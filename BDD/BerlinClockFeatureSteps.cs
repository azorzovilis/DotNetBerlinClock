namespace BerlinClock
{
    using Autofac;
    using BerlinClock.Classes.Interfaces;
    using BerlinClock.IoC;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TechTalk.SpecFlow;

    [Binding]
    public class TheBerlinClockSteps
    {
        private readonly ITimeConverter berlinClock;
        private string theTime;

        public TheBerlinClockSteps()
        {
            berlinClock = DependencyResolver.Initialize().Resolve<ITimeConverter>();
        }

        [When(@"the time is ""(.*)""")]
        public void WhenTheTimeIs(string time)
        {
            theTime = time;
        }

        [Then(@"the clock should look like")]
        public void ThenTheClockShouldLookLike(string theExpectedBerlinClockOutput)
        {
            Assert.AreEqual(berlinClock.convertTime(theTime), theExpectedBerlinClockOutput);
        }
    }
}