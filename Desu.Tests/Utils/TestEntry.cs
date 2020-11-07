using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wacton.Desu.Enums;
using Wacton.Desu.Japanese;

namespace Wacton.Desu.Tests
{
    public class TestEntry : IJapaneseEntry
    {
        public int Sequence { get; set; }

        public IEnumerable<IKanji> Kanjis { get; set; } = new List<IKanji>();

        public IEnumerable<IReading> Readings { get; set; } = new List<IReading>();

        public IEnumerable<ISense> Senses { get; set; } = new List<ISense>();

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
