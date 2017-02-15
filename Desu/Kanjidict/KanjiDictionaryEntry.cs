namespace Wacton.Desu.Kanjidict
{
    using System.Collections.Generic;

    public class KanjiDictionaryEntry : IKanjiDictionaryEntry
    {
        public string Literal { get; set; }

        private readonly List<string> radicalDecomposition = new List<string>();
        public IEnumerable<string> RadicalDecomposition => this.radicalDecomposition;

        private readonly List<ICodepoint> codepoints = new List<ICodepoint>();
        public IEnumerable<ICodepoint> Codepoints => this.codepoints;

        private readonly List<IBushuRadical> bushuRadicals = new List<IBushuRadical>();
        public IEnumerable<IBushuRadical> BushuRadicals => this.bushuRadicals;

        internal void AddRadicalDecomposition(List<string> radicals)
        {
            foreach (var radical in radicals)
            {
                this.radicalDecomposition.Add(radical);
            }
        }

        internal void AddCodepoint(ICodepoint codepoint)
        {
            this.codepoints.Add(codepoint);
        }

        internal void AddBushuRadical(IBushuRadical bushuRadical)
        {
            this.bushuRadicals.Add(bushuRadical);
        }

        //internal void StartNewSense()
        //{
        //    this.senses.Add(new Sense());
        //}

        //internal Sense GetSense() => this.senses.Last();

        public override string ToString()
        {
            return this.Literal;
        }
    }
}