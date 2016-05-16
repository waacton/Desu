namespace Wacton.Desu
{
    using System.Collections.Generic;

    public interface IKanji
    {
        string Text { get; }
        IEnumerable<KanjiInformation> Informations { get; }
        IEnumerable<Priority> Priorities { get; }
    }
}
