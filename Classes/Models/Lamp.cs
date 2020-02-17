namespace BerlinClock.Classes.Models
{
    internal class Lamp
    {
        internal Lamp(LampLight light)
        {
            Light = light;
        }

        internal LampLight Light { get; set; }
    }
}