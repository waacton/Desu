namespace Wacton.Desu.Kanji
{
    using System.Collections.Generic;

    using Wacton.Desu.Enums;

    public interface IMiscellaneousKanjiData
    {
        Grade Grade { get; }
        int StrokeCount { get; }
        IEnumerable<int> StrokeCommonMiscounts { get; }
        IEnumerable<IVariant> Variants { get; }
        int? Frequency { get; }
        IEnumerable<string> RadicalNames { get; } 
        int? JLPT { get; }
    }
}
