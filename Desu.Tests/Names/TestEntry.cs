using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wacton.Desu.Names;

namespace Wacton.Desu.Tests.Names
{
    public class TestEntry : INameEntry
    {
        public int Sequence { get; set; }

        public IEnumerable<IKanji> Kanjis { get; set; } = new List<IKanji>();

        public IEnumerable<IReading> Readings { get; set; } = new List<IReading>();

        public IEnumerable<ITranslation> Translations { get; set; } = new List<ITranslation>();

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

            stringBuilder.Append(Translations.First());
            return stringBuilder.ToString();
        }
    }
}
