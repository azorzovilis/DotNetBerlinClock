namespace BerlinClock.Classes.Interfaces
{
    using BerlinClock.Classes.Models;
    using System;

    public interface IRule
    {
        Func<int, int, LampLight> LampRule { get; }

        int LampsPerRow { get; }
    }
}
