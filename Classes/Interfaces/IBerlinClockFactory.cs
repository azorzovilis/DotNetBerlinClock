namespace BerlinClock.Classes.Interfaces
{
    using System;

    public interface IBerlinClockFactory
    {
        IClock GenerateBerlinClock(TimeSpan time);
    }
}