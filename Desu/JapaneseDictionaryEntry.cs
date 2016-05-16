namespace Wacton.Desu
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class JapaneseDictionaryEntry : IJapaneseDictionaryEntry
    {
        public int Sequence { get; set; }

        private readonly List<Kanji> kanjis = new List<Kanji>();
        public IEnumerable<IKanji> Kanjis => this.kanjis;

        private readonly List<Reading> readings = new List<Reading>();
        public IEnumerable<IReading> Readings => this.readings;

        private readonly List<Sense> senses = new List<Sense>();
        public IEnumerable<ISense> Senses => this.senses;


        internal void StartNewKanji()
        {
            this.kanjis.Add(new Kanji());
        }

        internal Kanji GetKanji() => this.kanjis.Last();

        internal void StartNewReading()
        {
            this.readings.Add(new Reading());
        }

        internal Reading GetReading() => this.readings.Last();

        internal void StartNewSense()
        {
            this.senses.Add(new Sense());
        }

        internal Sense GetSense() => this.senses.Last();

        public override string ToString()
        {
            var stringbuilder = new StringBuilder();
            stringbuilder.Append($"#{this.Sequence} :: ");

            foreach (var kanji in this.Kanjis)
            {
                stringbuilder.Append(kanji.Text + " | ");
            }

            foreach (var reading in this.Readings)
            {
                stringbuilder.Append(reading.Text + " | ");
            }

            stringbuilder.Append(this.Senses.First().Glosses.First(gloss => gloss.Language.Equals(Language.English)).Term);
            return stringbuilder.ToString();
        }
    }
}