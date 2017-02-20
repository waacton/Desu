namespace Wacton.Desu.Kanji
{
    using System.Collections.Generic;
    using System.Linq;

    using Wacton.Desu.Enums;

    public class KanjiDictionaryEntry : IKanjiDictionaryEntry
    {
        public string Literal { get; set; }

        private readonly List<string> radicalDecomposition = new List<string>();
        public List<string> GetRadicalDecompositions() => this.radicalDecomposition;
        public IEnumerable<string> RadicalDecomposition => this.GetRadicalDecompositions();

        private readonly List<Codepoint> codepoints = new List<Codepoint>();
        public List<Codepoint> GetCodepoints() => this.codepoints;
        public IEnumerable<ICodepoint> Codepoints => this.GetCodepoints();

        private readonly List<IBushuRadical> bushuRadicals = new List<IBushuRadical>();
        public List<IBushuRadical> GetBushuRadicals() => this.bushuRadicals;
        public IEnumerable<IBushuRadical> BushuRadicals => this.GetBushuRadicals();

        public bool IsBushuRadical => this.bushuRadicals.Single(radical => radical.Type.Equals(BushuRadicalType.Classical)).Radical.Equals(this.Literal);

        private readonly MiscellaneousKanjiData miscellaneous = new MiscellaneousKanjiData();
        public MiscellaneousKanjiData GetMiscellaneous() => this.miscellaneous;
        public IMiscellaneousKanjiData Miscellaneous => this.GetMiscellaneous();

        private readonly List<Reference> references = new List<Reference>();
        public List<Reference> GetReferences() => this.references;
        public IEnumerable<IReference> References => this.GetReferences();

        private readonly List<QueryCode> queryCodes = new List<QueryCode>();
        public List<QueryCode> GetQueryCodes() => this.queryCodes;
        public IEnumerable<IQueryCode> QueryCodes => this.GetQueryCodes();

        private readonly List<KanjiReading> readings = new List<KanjiReading>();
        public List<KanjiReading> GetReadings() => this.readings;
        public IEnumerable<IKanjiReading> Readings => this.GetReadings();

        private readonly List<KanjiMeaning> meanings = new List<KanjiMeaning>();
        public List<KanjiMeaning> GetMeanings() => this.meanings;
        public IEnumerable<IKanjiMeaning> Meanings => this.GetMeanings();

        private readonly List<string> nanoris = new List<string>();
        public List<string> GetNanoris() => this.nanoris;
        public IEnumerable<string> Nanoris => this.GetNanoris();

        public override string ToString()
        {
            return this.Literal;
        }
    }
}