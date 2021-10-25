namespace Wacton.Desu.Names
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class NameEntry : INameEntry
    {
        public int Sequence { get; set; }

        private readonly List<Kanji> kanjis = new List<Kanji>();
        public List<Kanji> GetKanjis() => this.kanjis;
        public IEnumerable<IKanji> Kanjis => this.GetKanjis();
        internal void StartNewKanji()
        {
            this.kanjis.Add(new Kanji());
        }

        private readonly List<Reading> readings = new List<Reading>();
        public List<Reading> GetReadings() => this.readings;
        public IEnumerable<IReading> Readings => this.GetReadings();
        internal void StartNewReading()
        {
            this.readings.Add(new Reading());
        }

        private readonly List<Translation> translations = new List<Translation>();
        public List<Translation> GetTranslations() => this.translations;
        public IEnumerable<ITranslation> Translations => this.GetTranslations();
        internal void StartNewSense()
        {
            this.translations.Add(new Translation());
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append($"#{this.Sequence} :: ");

            foreach (var kanji in this.Kanjis)
            {
                stringBuilder.Append(kanji.Text + " · ");
            }

            foreach (var reading in this.Readings)
            {
                stringBuilder.Append(reading.Text + " · ");
            }

            stringBuilder.Append(this.Translations.First());
            return stringBuilder.ToString();
        }
    }
}