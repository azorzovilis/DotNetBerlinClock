namespace BerlinClock.Classes.Models.Rules
{
    using BerlinClock.Classes.Interfaces;
    using System;

    public class TopHoursRule : IRule
    {
        public Func<int, int, LampLight> LampRule => (hours, index) => hours / (5 * (index + 1)) >= 1 ? LampLight.Red : LampLight.Off;

        public int LampsPerRow => 4;
    }
}
