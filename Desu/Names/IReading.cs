namespace Wacton.Desu.Names
{
    using System.Collections.Generic;

    using Wacton.Desu.Enums;

    public interface IReading
    {
        string Text { get; }
        IEnumerable<string> Restriction { get; }
        IEnumerable<ReadingInformation> Informations { get; }
        IEnumerable<Priority> Priorities { get; }
    }
}
