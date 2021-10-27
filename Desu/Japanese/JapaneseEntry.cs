namespace Wacton.Desu.Japanese
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Wacton.Desu.Enums;

    internal class JapaneseEntry : IJapaneseEntry
    {
        public int Sequence { get; set; }

        internal readonly List<Kanji> KanjisList = new List<Kanji>();
        public IEnumerable<IKanji> Kanjis => KanjisList;
        internal void StartNewKanji() => KanjisList.Add(new Kanji());

        internal readonly List<Reading> ReadingsList = new List<Reading>();
        public IEnumerable<IReading> Readings => ReadingsList;
        internal void StartNewReading() => ReadingsList.Add(new Reading());

        internal readonly List<Sense> SensesList = new List<Sense>();
        public IEnumerable<ISense> Senses => SensesList;
        internal void StartNewSense() => SensesList.Add(new Sense());

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append($"#{Sequence} :: ");

            foreach (var kanji in Kanjis)
            {
                stringBuilder.Append(kanji.Text + " · ");
            }

            foreach (var reading in Readings)
            {
                stringBuilder.Append(reading.Text + " · ");
            }

            stringBuilder.Append(Senses.First().Glosses.First(gloss => gloss.Language.Equals(Language.English)).Term);
            return stringBuilder.ToString();
        }
    }
}