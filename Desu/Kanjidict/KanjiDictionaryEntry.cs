namespace Wacton.Desu.Kanjidict
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class KanjiDictionaryEntry : IKanjiDictionaryEntry
    {
        public string Literal { get; set; }

        //private readonly List<Kanji> kanjis = new List<Kanji>();
        //public IEnumerable<IKanji> Kanjis => this.kanjis;

        //private readonly List<Reading> readings = new List<Reading>();
        //public IEnumerable<IReading> Readings => this.readings;

        //private readonly List<Sense> senses = new List<Sense>();
        //public IEnumerable<ISense> Senses => this.senses;


        //internal void StartNewKanji()
        //{
        //    this.kanjis.Add(new Kanji());
        //}

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