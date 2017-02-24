namespace Wacton.Desu.Kanji
{
    using System.Collections.Generic;

    using Wacton.Desu.Enums;

    public interface IKanjiEntry
    {
        string Literal { get; }
        IEnumerable<string> RadicalDecomposition { get; }
        IEnumerable<ICodepoint> Codepoints { get; }
        IEnumerable<string> StrokePaths { get; }
        IEnumerable<IBushuRadical> BushuRadicals { get; }
        bool IsBushuRadical { get; }
        Grade Grade { get; }
        int StrokeCount { get; }
        IEnumerable<int> StrokeCommonMiscounts { get; }
        IEnumerable<IVariant> Variants { get; }
        int? Frequency { get; }
        IEnumerable<string> RadicalNames { get; }
        int? JLPT { get; }
        IEnumerable<IReference> References { get; }
        IEnumerable<IQueryCode> QueryCodes { get; }
        IEnumerable<IReading> Readings { get; }
        IEnumerable<IMeaning> Meanings { get; }
        IEnumerable<string> Nanoris { get; }
    }
}
