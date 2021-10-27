namespace Wacton.Desu.Names
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    internal class NameEntry : INameEntry
    {
        public int Sequence { get; set; }

        internal readonly List<Kanji> KanjisList = new List<Kanji>();
        public IEnumerable<IKanji> Kanjis => KanjisList;
        internal void StartNewKanji() => KanjisList.Add(new Kanji());

        internal readonly List<Reading> ReadingsList = new List<Reading>();
        public IEnumerable<IReading> Readings => ReadingsList;
        internal void StartNewReading() => ReadingsList.Add(new Reading());

        internal readonly List<Translation> TranslationsList = new List<Translation>();
        public IEnumerable<ITranslation> Translations => TranslationsList;
        internal void StartNewTranslation() => TranslationsList.Add(new Translation());

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