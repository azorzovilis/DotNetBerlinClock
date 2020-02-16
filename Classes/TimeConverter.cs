namespace BerlinClock.Classes
{
    using BerlinClock.Classes.Interfaces;
    using System;
    using System.Linq;

    public class TimeConverter : ITimeConverter
    {
        private readonly IBerlinClockContext _berlinClockContext;
        private readonly ITimeValidator _timeValidator;

        public TimeConverter(IBerlinClockContext berlinClockContext, ITimeValidator timeValidator)
        {
            _berlinClockContext = berlinClockContext;
            _timeValidator = timeValidator;
        }

        public string ConvertTime(string aTime)
        {
            if (!_timeValidator.IsValidTime(aTime))
            {
                throw new ArgumentException($"{aTime} is an invalid time", aTime);
            }

            var parsedTime = ParseGivenTime(aTime);
            _berlinClockContext.SetBerlinClockTime(parsedTime);

            return _berlinClockContext.GetBerlinClock().ToString();
        }

        private TimeSpan ParseGivenTime(string aTime)
        {
            var timeArray = aTime.Split(':').Select(int.Parse).ToArray();
            return new TimeSpan(timeArray[0], timeArray[1], timeArray[2]);
        }
    }
}