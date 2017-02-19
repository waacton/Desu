namespace Wacton.Desu.Kanjidict
{
    using System.Collections.Generic;

    public class MiscellaneousKanjiData : IMiscellaneousKanjiData
    {
        public Grade Grade { get; set; } = Grade.None;

        public int StrokeCount { get; set; }

        private readonly List<int> strokeCommonMiscounts = new List<int>();
        public IEnumerable<int> StrokeCommonMiscounts => this.strokeCommonMiscounts;
        internal void AddStrokeCommonMiscount(int strokeMiscount)
        {
            this.strokeCommonMiscounts.Add(strokeMiscount);
        }

        private readonly List<IVariant> variants = new List<IVariant>();
        public IEnumerable<IVariant> Variants => this.variants;
        internal void AddVariant(IVariant variant)
        {
            this.variants.Add(variant);
        }

        public int? Frequency { get; set; }

        private readonly List<string> radicalNames = new List<string>();
        public IEnumerable<string> RadicalNames => this.radicalNames;
        internal void AddRadicalName(string radicalName)
        {
            this.radicalNames.Add(radicalName);
        }

        public int? JLPT { get; set; }

        public override string ToString()
        {
            return $"Grade: {this.Grade} | Strokes: {this.StrokeCount}";
        }
    }
}
