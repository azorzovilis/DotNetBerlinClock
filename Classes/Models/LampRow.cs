namespace BerlinClock.Classes.Models
{
    using System.Collections.Generic;
    using System.Linq;

    public class LampRow
    {
        public LampRow()
        {
            Lamps = new List<Lamp>();
        }

        public IList<Lamp> Lamps { get; internal set; }

        public override string ToString()
        {
            return string.Concat(Lamps.Select(lamp => (char)lamp.Light));
        }
    }
}