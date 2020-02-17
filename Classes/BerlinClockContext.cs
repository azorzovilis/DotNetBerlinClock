namespace BerlinClock.Classes
{
    using BerlinClock.Classes.Interfaces;
    using System;

    public class BerlinClockContext : IBerlinClockContext
    {
        private readonly IBerlinClockFactory _clockFactory;
        private IClock _berlinClock;

        public BerlinClockContext(IBerlinClockFactory clockFactory)
        {
            _clockFactory = clockFactory;

            //The clock by default has it's time set to "00:00:00"
            _berlinClock = SetBerlinClockTime(TimeSpan.Zero);
        }

        public IClock SetBerlinClockTime(TimeSpan time)
        {
            return _berlinClock = _clockFactory.GenerateBerlinClock(time);
        }

        public IClock GetBerlinClock()
        {
            return _berlinClock;
        }
    }
}
