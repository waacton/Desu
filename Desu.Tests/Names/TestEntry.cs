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

            stringbuilder.Append(this.Translations.First());
            return stringbuilder.ToString();
        }
    }
}
