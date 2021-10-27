using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using Wacton.Desu.Names;
using Wacton.Desu.Tests.Names;

namespace Wacton.Desu.Tests
{
    public class NameAssert
    {
        public static void AssertEntry(TestEntry testEntry, IEnumerable<INameEntry> nameEntries)
        {
            var entry = nameEntries.Single(x => x.Sequence == testEntry.Sequence);
            AssertEntriesAreEqual(entry, testEntry);
        }

        private static void AssertEntriesAreEqual(INameEntry first, INameEntry second)
        {
            Assert.That(first.Sequence, Is.EqualTo(second.Sequence));
            AssertKanjisAreEqual(first.Kanjis, second.Kanjis);
            AssertReadingsAreEqual(first.Readings, second.Readings);
            AssertTranslationsAreEqual(first.Translations, second.Translations);
        }

        private static void AssertKanjisAreEqual(IEnumerable<IKanji> firstList, IEnumerable<IKanji> secondList)
        {
            if (firstList.Count() != secondList.Count())
            {
                Assert.Fail("Kanjis are different lengths");
            }

            for (var i = 0; i < firstList.Count(); i++)
            {
                var first = firstList.ElementAt(i);
                var second = secondList.ElementAt(i);

                Assert.That(first.Text, Is.EqualTo(second.Text));
                Assert.That(first.Informations, Is.EqualTo(second.Informations));
                Assert.That(first.Priorities, Is.EqualTo(second.Priorities));
            }
        }

        private static void AssertReadingsAreEqual(IEnumerable<IReading> firstList, IEnumerable<IReading> secondList)
        {
            if (firstList.Count() != secondList.Count())
            {
                Assert.Fail("Readings are different lengths");
            }

            for (var i = 0; i < firstList.Count(); i++)
            {
                var first = firstList.ElementAt(i);
                var second = secondList.ElementAt(i);

                Assert.That(first.Text, Is.EqualTo(second.Text));
                Assert.That(first.Restriction, Is.EqualTo(second.Restriction));
                Assert.That(first.Informations, Is.EqualTo(second.Informations));
                Assert.That(first.Priorities, Is.EqualTo(second.Priorities));
            }
        }

        private static void AssertTranslationsAreEqual(IEnumerable<ITranslation> firstList, IEnumerable<ITranslation> secondList)
        {
            if (firstList.Count() != secondList.Count())
            {
                Assert.Fail("Translations are different lengths");
            }

            for (var i = 0; i < firstList.Count(); i++)
            {
                var first = firstList.ElementAt(i);
                var second = secondList.ElementAt(i);

                Assert.That(first.NameTypes, Is.EqualTo(second.NameTypes));
                Assert.That(first.CrossReferences, Is.EqualTo(second.CrossReferences));
                Assert.That(first.Transcriptions, Is.EqualTo(second.Transcriptions));
            }
        }
    }
}