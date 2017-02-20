namespace Wacton.Desu.Japanese
{
    using System.Collections.Generic;

    using Wacton.Desu.Enums;

    public interface IKanji
    {
        string Text { get; }
        IEnumerable<KanjiInformation> Informations { get; }
        IEnumerable<Priority> Priorities { get; }
    }
}
