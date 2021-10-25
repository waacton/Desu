﻿namespace Wacton.Desu.Japanese
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Wacton.Desu.Enums;

    public class JapaneseEntry : IJapaneseEntry
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

        private readonly List<Sense> senses = new List<Sense>();
        public List<Sense> GetSenses() => this.senses;
        public IEnumerable<ISense> Senses => this.GetSenses();
        internal void StartNewSense()
        {
            this.senses.Add(new Sense());
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

            stringBuilder.Append(this.Senses.First().Glosses.First(gloss => gloss.Language.Equals(Language.English)).Term);
            return stringBuilder.ToString();
        }
    }
}