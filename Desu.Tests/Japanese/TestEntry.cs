using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wacton.Desu.Enums;
using Wacton.Desu.Japanese;

namespace Wacton.Desu.Tests.Japanese
{
    public class TestEntry : IJapaneseEntry
    {
        public int Sequence { get; set; }

        public IEnumerable<IKanji> Kanjis { get; set; } = new List<IKanji>();

        public IEnumerable<IReading> Readings { get; set; } = new List<IReading>();

        public IEnumerable<ISense> Senses { get; set; } = new List<ISense>();

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
