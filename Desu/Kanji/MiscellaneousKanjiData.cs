namespace Wacton.Desu.Kanji
{
    using System.Collections.Generic;

    using Wacton.Desu.Enums;

    public class MiscellaneousKanjiData : IMiscellaneousKanjiData
    {
        public Grade Grade { get; set; } = Grade.None;

        public int StrokeCount { get; set; }

        private readonly List<int> strokeCommonMiscounts = new List<int>();
        public List<int> GetStrokeMiscounts() => this.strokeCommonMiscounts;
        public IEnumerable<int> StrokeCommonMiscounts => this.GetStrokeMiscounts();

        private readonly List<Variant> variants = new List<Variant>();
        public List<Variant> GetVariants() => this.variants;
        public IEnumerable<IVariant> Variants => this.GetVariants();

        public int? Frequency { get; set; }

        private readonly List<string> radicalNames = new List<string>();
        public List<string> GetRadicalNames() => this.radicalNames;
        public IEnumerable<string> RadicalNames => this.GetRadicalNames();

        public int? JLPT { get; set; }

        public override string ToString()
        {
            return $"Grade: {this.Grade} | Strokes: {this.StrokeCount}";
        }
    }
}
