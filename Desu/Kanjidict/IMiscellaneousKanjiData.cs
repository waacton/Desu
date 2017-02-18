namespace Wacton.Desu.Kanjidict
{
    using System.Collections.Generic;

    public interface IMiscellaneousKanjiData
    {
        Grade Grade { get; }
        int StrokeCount { get; }
        List<int> StrokeCommonMiscounts { get; }
    }
}
