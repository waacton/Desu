namespace Wacton.Desu.Kanjidict
{
    using System.Collections.Generic;

    public class MiscellaneousKanjiData : IMiscellaneousKanjiData
    {
        public Grade Grade { get; set; } = Grade.None;
        public int StrokeCount { get; set; }
        public List<int> StrokeCommonMiscounts { get; set; } = new List<int>();

        public override string ToString()
        {
            return $"Grade: {this.Grade} | Strokes: {this.StrokeCount}";
        }
    }
}
