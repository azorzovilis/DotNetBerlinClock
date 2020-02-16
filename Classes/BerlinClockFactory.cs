namespace BerlinClock.Classes
{
    using BerlinClock.Classes.Interfaces;
    using BerlinClock.Classes.Models;
    using BerlinClock.Classes.Models.Rules;
    using System;

    public class BerlinClockFactory : IBerlinClockFactory
    {
        public Clock GenerateBerlinClock(TimeSpan time)
        {
            var parts = GetTimeParts(time);

            return new Clock
            {
                TopSecondsRow = GenerateLine(parts.Seconds, new TopSecondsRowRule()),
                TopHoursRow = GenerateLine(parts.Hours, new TopHoursRule()),
                BottomHoursRow = GenerateLine(parts.Hours, new BottomHoursRule()),
                TopMinutesRow = GenerateLine(parts.Minutes, new TopMinutesRule()),
                BottomMinutesRow = GenerateLine(parts.Minutes, new BottomMinutesRule())
            };
        }

        private LampRow GenerateLine(int timeUnit, IRule rule)
        {
            var lampRow = new LampRow();
            for (int index = 0; index < rule.LampsPerRow; index++)
            {
                var lightColour = rule.LampRule(timeUnit, index);
                lampRow.Lamps.Add(new Lamp(lightColour));
            }
            return lampRow;
        }

        // 24:00:00 is an exception since TimeSpan cannot represent this value
        private dynamic GetTimeParts(TimeSpan time)
        {
            return time.Days == 1
                ? new { Hours = 24, time.Minutes, time.Seconds }
                : new { time.Hours, time.Minutes, time.Seconds };
        }
    }
}
