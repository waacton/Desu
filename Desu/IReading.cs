namespace Wacton.Desu
{
    using System.Collections.Generic;

    public interface IReading
    {
        string Text { get; }
        bool IsTrueKanjiReading { get; }
        IEnumerable<string> Restricted { get; }
        IEnumerable<ReadingInformation> Informations { get; }
        IEnumerable<Priority> Priorities { get; }
    }
}
