namespace BerlinClock.Classes.Models
{
    using System.Text;

    public class Clock
    {
        public Clock()
        {
            TopSecondsRow = new LampRow();
            TopMinutesRow = new LampRow();
            BottomMinutesRow = new LampRow();
            TopHoursRow = new LampRow();
            BottomHoursRow = new LampRow();
        }

        public LampRow TopSecondsRow { get; internal set; }
        public LampRow TopMinutesRow { get; internal set; }
        public LampRow BottomMinutesRow { get; internal set; }
        public LampRow TopHoursRow { get; internal set; }
        public LampRow BottomHoursRow { get; internal set; }

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