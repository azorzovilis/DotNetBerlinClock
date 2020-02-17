namespace BerlinClock.Classes.Interfaces
{
    using System;

    public interface IBerlinClockContext
    {
        IClock SetBerlinClockTime(TimeSpan time);

        IClock GetBerlinClock();
    }
}