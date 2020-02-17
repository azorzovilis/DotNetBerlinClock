namespace BerlinClock.Classes.Models.Rules
{
    using BerlinClock.Classes.Interfaces;
    using System;

    internal class BottomHoursRule : IRule
    {
        public Func<int, int, LampLight> LampRule => (hours, index) => (index + 1) <= hours % 5 ? LampLight.Red : LampLight.Off;
    }
}
