namespace BerlinClock.Classes.Interfaces
{
    using BerlinClock.Classes.Models;
    using System;

    public interface IBerlinClockContext
    {
        Clock SetBerlinClockTime(TimeSpan time);

        Clock GetBerlinClock();
    }
}