namespace BerlinClock.Classes.Models.Rules
{
    using BerlinClock.Classes.Interfaces;
    using System;

    internal class BottomMinutesRule : IRule
    {
        public Func<int, int, LampLight> LampRule => (minutes, index) => (index + 1) <= minutes % 5 ? LampLight.Yellow : LampLight.Off;
    }
}
