namespace BerlinClock.Classes.Interfaces
{
    using BerlinClock.Classes.Models;
    using System;

    public interface IBerlinClockFactory
    {
        Clock GenerateBerlinClock(TimeSpan time);
    }
}