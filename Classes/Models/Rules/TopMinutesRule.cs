namespace BerlinClock.Classes.Models.Rules
{
    using BerlinClock.Classes.Interfaces;
    using System;

    internal class TopMinutesRule : IRule
    {
        public Func<int, int, LampLight> LampRule => (minutes, index) => 
            minutes / (5 * (index + 1)) >= 1 
                ? ((index == (3 - 1) || index == (6 - 1) || index == (9 - 1)) ? LampLight.Red : LampLight.Yellow) 
                : LampLight.Off;
    }
}
