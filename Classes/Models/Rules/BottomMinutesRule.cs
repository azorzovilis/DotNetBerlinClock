namespace BerlinClock.Classes.Models.Rules
{
    using BerlinClock.Classes.Interfaces;
    using System;

    public class BottomMinutesRule : IRule
    {
        public Func<int, int, LampLight> LampRule => (minutes, index) => (index + 1) <= minutes % 5 ? LampLight.Yellow : LampLight.Off;

        public int LampsPerRow => 4;
    }
}
