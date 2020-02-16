namespace BerlinClock.Classes
{
    using BerlinClock.Classes.Interfaces;
    using BerlinClock.Classes.Models;
    using System;

    public class BerlinClockContext : IBerlinClockContext
    {
        private readonly IBerlinClockFactory _clockFactory;
        private Clock _berlinClock;

        public BerlinClockContext(IBerlinClockFactory clockFactory)
        {
            _clockFactory = clockFactory;

            //The clock by default has it's time set to "00:00:00"
            _berlinClock = SetBerlinClockTime(TimeSpan.Zero);
        }

        public Clock SetBerlinClockTime(TimeSpan time)
        {
            return _berlinClock = _clockFactory.GenerateBerlinClock(time);
        }

        public Clock GetBerlinClock()
        {
            return _berlinClock;
        }
    }
}
