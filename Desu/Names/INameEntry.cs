namespace Wacton.Desu.Names
{
    using System.Collections.Generic;

    public interface INameEntry
    {
        int Sequence { get; }
        IEnumerable<IKanji> Kanjis { get; }
        IEnumerable<IReading> Readings { get; }
        IEnumerable<ITranslation> Translations { get; }
    }
}
