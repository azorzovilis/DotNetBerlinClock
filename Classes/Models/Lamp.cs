namespace BerlinClock.Classes.Models
{
    public class Lamp
    {
        public Lamp(LampLight light)
        {
            Light = light;
        }

        public LampLight Light { get; internal set; }
    }
}