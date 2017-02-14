namespace Wacton.Desu.Kanjidict
{
    using System.Collections.Generic;

    public interface IKanjiDictionaryEntry
    {
        string Literal { get; }
        //IEnumerable<IKanji> Kanjis { get; }
        //IEnumerable<IReading> Readings { get; }
        //IEnumerable<ISense> Senses { get; }
    }
}
