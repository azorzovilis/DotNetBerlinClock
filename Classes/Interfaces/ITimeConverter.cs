namespace BerlinClock
{
    using System;

    public interface ITimeConverter
    {
        string ConvertTime(string aTime);

        [Obsolete("Use ConvertTime instead")]
        String convertTime(String aTime);
    }
}
