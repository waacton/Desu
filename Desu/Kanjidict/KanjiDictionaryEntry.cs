namespace Wacton.Desu.Kanjidict
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class KanjiDictionaryEntry : IKanjiDictionaryEntry
    {
        public string Literal { get; set; }

        private readonly List<ICodepoint> codepoints = new List<ICodepoint>();
        public IEnumerable<ICodepoint> Codepoints => this.codepoints;

        //private readonly List<Reading> readings = new List<Reading>();
        //public IEnumerable<IReading> Readings => this.readings;

        //private readonly List<Sense> senses = new List<Sense>();
        //public IEnumerable<ISense> Senses => this.senses;

        internal void AddCodepoint(ICodepoint codepoint)
        {
            this.codepoints.Add(codepoint);
        }

        //internal Kanji GetKanji() => this.kanjis.Last();

        //internal void StartNewReading()
        //{
        //    this.readings.Add(new Reading());
        //}

        //internal Reading GetReading() => this.readings.Last();

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