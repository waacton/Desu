namespace Wacton.Desu.Kanji
{
    using System.Collections.Generic;
    using System.Linq;

    using Wacton.Desu.Enums;
    using Wacton.Tovarisch.Collections;

    public class KanjiEntry : IKanjiEntry
    {
        public string Literal { get; set; }

        private readonly List<string> radicalDecomposition = new List<string>();
        public List<string> GetRadicalDecompositions() => this.radicalDecomposition;
        public IEnumerable<string> RadicalDecomposition => this.GetRadicalDecompositions();

        private readonly List<Codepoint> codepoints = new List<Codepoint>();
        public List<Codepoint> GetCodepoints() => this.codepoints;
        public IEnumerable<ICodepoint> Codepoints => this.GetCodepoints();

        private readonly List<string> strokePaths = new List<string>();
        public List<string> GetStrokePaths() => this.strokePaths;
        public IEnumerable<string> StrokePaths => this.GetStrokePaths();

        private readonly List<IBushuRadical> bushuRadicals = new List<IBushuRadical>();
        public List<IBushuRadical> GetBushuRadicals() => this.bushuRadicals;
        public IEnumerable<IBushuRadical> BushuRadicals => this.GetBushuRadicals();

        public bool IsBushuRadical => this.bushuRadicals.Single(radical => radical.Type.Equals(BushuRadicalType.Classical)).Radical.Equals(this.Literal);

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

        private readonly List<Reference> references = new List<Reference>();
        public List<Reference> GetReferences() => this.references;
        public IEnumerable<IReference> References => this.GetReferences();

        private readonly List<QueryCode> queryCodes = new List<QueryCode>();
        public List<QueryCode> GetQueryCodes() => this.queryCodes;
        public IEnumerable<IQueryCode> QueryCodes => this.GetQueryCodes();

        private readonly List<Reading> readings = new List<Reading>();
        public List<Reading> GetReadings() => this.readings;
        public IEnumerable<IReading> Readings => this.GetReadings();

        private readonly List<Meaning> meanings = new List<Meaning>();
        public List<Meaning> GetMeanings() => this.meanings;
        public IEnumerable<IMeaning> Meanings => this.GetMeanings();

        private readonly List<string> nanoris = new List<string>();
        public List<string> GetNanoris() => this.nanoris;
        public IEnumerable<string> Nanoris => this.GetNanoris();

        public override string ToString()
        {
            var english = this.Meanings.Where(meaning => meaning.Language.Equals(Language.English)).Select(meaning => meaning.Term).ToDelimitedString(" | ");
            return $"{this.Literal}{(string.IsNullOrEmpty(english) ? string.Empty : " | " + english)}";
        }
    }
}