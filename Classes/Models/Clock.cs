namespace BerlinClock.Classes.Models
{
    using BerlinClock.Classes.Interfaces;
    using System.Text;

    internal class Clock : IClock
    {
        internal Clock()
        {
            TopSecondsRow = new LampRow();
            TopMinutesRow = new LampRow();
            BottomMinutesRow = new LampRow();
            TopHoursRow = new LampRow();
            BottomHoursRow = new LampRow();
        }

        internal LampRow TopSecondsRow { get; set; }
        internal LampRow TopMinutesRow { get; set; }
        internal LampRow BottomMinutesRow { get; set; }
        internal LampRow TopHoursRow { get; set; }
        internal LampRow BottomHoursRow { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(string.Join(string.Empty, TopSecondsRow.ToString()));
            sb.AppendLine(string.Join(string.Empty, TopHoursRow.ToString()));
            sb.AppendLine(string.Join(string.Empty, BottomHoursRow.ToString()));
            sb.AppendLine(string.Join(string.Empty, TopMinutesRow.ToString()));
            sb.Append(string.Join(string.Empty, BottomMinutesRow.ToString()));

            return sb.ToString();
        }
    }
}