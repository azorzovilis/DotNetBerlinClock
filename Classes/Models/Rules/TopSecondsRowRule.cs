namespace BerlinClock.Classes.Models.Rules
{
    using BerlinClock.Classes.Interfaces;
    using System;

    internal class TopSecondsRowRule : IRule
    {
        public Func<int, int, LampLight> LampRule => (seconds, index) => seconds % 2 == 0 ? LampLight.Yellow : LampLight.Off;
    }
}
