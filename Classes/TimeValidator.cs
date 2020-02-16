namespace BerlinClock.Classes
{
    using BerlinClock.Classes.Interfaces;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class TimeValidator : ITimeValidator
    {
        public bool IsValidTime(string time)
        {
            if (!Regex.IsMatch(time, "[0-2][0-9]:[0-5][0-9]:[0-5][0-9]"))
            {
                return false;
            }

            var hours = int.Parse(time.Split(':').First());
            return hours <= 24;
        }
    }
}
