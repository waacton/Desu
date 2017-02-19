namespace Wacton.Desu.Kanjidict
{
    using System.Collections.Generic;

    public interface IKanjiDictionaryEntry
    {
        string Literal { get; }
        IEnumerable<string> RadicalDecomposition { get; }
        IEnumerable<ICodepoint> Codepoints { get; }
        IEnumerable<IBushuRadical> BushuRadicals { get; }
        bool IsBushuRadical { get; }
        IMiscellaneousKanjiData Miscellaneous { get; }
        IEnumerable<IReference> References { get; }
        IEnumerable<IQueryCode> QueryCodes { get; }
        IEnumerable<IKanjiReading> Readings { get; }
        IEnumerable<IKanjiMeaning> Meanings { get; }
        IEnumerable<string> Nanoris { get; }
    }
}
