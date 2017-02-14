namespace Wacton.Desu.Kanjidict
{
    using System.Collections.Generic;

    public interface IKanjiDictionary
    {
        IEnumerable<IKanjiDictionaryEntry> GetEntries();
    }
}
