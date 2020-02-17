using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("UnitTests")]
namespace BerlinClock.Classes.Interfaces
{
    using BerlinClock.Classes.Models;
    using System;

    internal interface IRule
    {
        Func<int, int, LampLight> LampRule { get; }
    }
}
