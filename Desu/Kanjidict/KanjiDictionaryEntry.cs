namespace Wacton.Desu.Kanjidict
{
    using System.Collections.Generic;
    using System.Linq;

    public class KanjiDictionaryEntry : IKanjiDictionaryEntry
    {
        public string Literal { get; set; }

        private readonly List<string> radicalDecomposition = new List<string>();
        public IEnumerable<string> RadicalDecomposition => this.radicalDecomposition;
        internal void AddRadicalDecomposition(List<string> radicals)
        {
            foreach (var radical in radicals)
            {
                this.radicalDecomposition.Add(radical);
            }
        }

        private readonly List<ICodepoint> codepoints = new List<ICodepoint>();
        public IEnumerable<ICodepoint> Codepoints => this.codepoints;
        internal void AddCodepoint(ICodepoint codepoint)
        {
            this.codepoints.Add(codepoint);
        }

        private readonly List<IBushuRadical> bushuRadicals = new List<IBushuRadical>();
        public IEnumerable<IBushuRadical> BushuRadicals => this.bushuRadicals;
        internal void AddBushuRadical(IBushuRadical bushuRadical)
        {
            this.bushuRadicals.Add(bushuRadical);
        }

        public bool IsBushuRadical => this.bushuRadicals.Single(radical => radical.Type.Equals(BushuRadicalType.Classical)).Radical.Equals(this.Literal);

        private readonly MiscellaneousKanjiData miscellaneous = new MiscellaneousKanjiData();
        public IMiscellaneousKanjiData Miscellaneous => this.miscellaneous;
        internal MiscellaneousKanjiData GetMiscellaneous() => this.miscellaneous;

        private readonly List<IReference> references = new List<IReference>();
        public IEnumerable<IReference> References => this.references;
        internal void AddReference(IReference reference)
        {
            this.references.Add(reference);
        }

        private readonly List<IQueryCode> queryCodes = new List<IQueryCode>();
        public IEnumerable<IQueryCode> QueryCodes => this.queryCodes;
        internal void AddQueryCode(IQueryCode queryCode)
        {
            this.queryCodes.Add(queryCode);
        }

        private readonly List<IKanjiReading> readings = new List<IKanjiReading>();
        public IEnumerable<IKanjiReading> Readings => this.readings;
        internal void AddReading(IKanjiReading reading)
        {
            this.readings.Add(reading);
        }

        private readonly List<IKanjiMeaning> meanings = new List<IKanjiMeaning>();
        public IEnumerable<IKanjiMeaning> Meanings => this.meanings;
        internal void AddMeaning(IKanjiMeaning meaning)
        {
            this.meanings.Add(meaning);
        }

        private readonly List<string> nanoris = new List<string>();
        public IEnumerable<string> Nanoris => this.nanoris;
        internal void AddNanori(string nanori)
        {
            this.nanoris.Add(nanori);
        }

        public override string ToString()
        {
            return this.Literal;
        }
    }
}