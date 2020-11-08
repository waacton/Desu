using System.Collections.Generic;
using System.Linq;
using Wacton.Desu.Enums;
using Wacton.Desu.Names;

namespace Wacton.Desu.Tests.Names
{
    public static class TestEntries
    {
        public static TestEntry 国語研究所()
        {
            var kanji1 = new TestKanji
            {
                Text = "国語研究所"
            };

            var reading1 = new TestReading
            {
                Text = "こくごけんきゅうじょ"
            };

            var translation1 = new TestTranslation
            {
                NameTypes = new List<NameType> { NameType("organization name") },
                CrossReferences = new List<string> { "国立国語研究所" },
                Transcriptions = new List<string> { "National Institute for Japanese Language and Linguistics", "NINJAL", "Kokken" }
            };

            var testEntry = new TestEntry
            {
                Sequence = 5294339,
                Kanjis = new List<IKanji> { kanji1 },
                Readings = new List<IReading> { reading1 },
                Translations = new List<ITranslation> { translation1 }
            };

            return testEntry;
        }

        public static TestEntry ガラパゴス()
        {
            var reading1 = new TestReading
            {
                Text = "ガラパゴス"
            };

            var translation1 = new TestTranslation
            {
                NameTypes = new List<NameType> { NameType("place name") },
                Transcriptions = new List<string> { "Galapagos (island chain)" }
            };

            var translation2 = new TestTranslation
            {
                NameTypes = new List<NameType> { NameType("product name") },
                Transcriptions = new List<string> { "Sharp brand of e-readers and mobile phones" }
            };

            var testEntry = new TestEntry
            {
                Sequence = 5024564,
                Readings = new List<IReading> { reading1 },
                Translations = new List<ITranslation> { translation1, translation2 }
            };

            return testEntry;
        }

        private static NameType NameType(string code) => Enumeration.GetAll<NameType>().Single(x => x.Code == code);
    }
}
