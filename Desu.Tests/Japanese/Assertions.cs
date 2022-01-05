using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using Wacton.Desu.Japanese;

namespace Wacton.Desu.Tests.Japanese
{
    public static class Assertions
    {
        public static void AssertEntry(TestEntry testEntry, IEnumerable<IJapaneseEntry> japaneseEntries)
        {
            var entry = japaneseEntries.Single(x => x.Sequence == testEntry.Sequence);
            AssertEntriesAreEqual(entry, testEntry);
        }

        private static void AssertEntriesAreEqual(IJapaneseEntry first, IJapaneseEntry second)
        {
            Assert.That(first.Sequence, Is.EqualTo(second.Sequence));
            AssertKanjisAreEqual(first.Kanjis, second.Kanjis);
            AssertReadingsAreEqual(first.Readings, second.Readings);
            AssertSensesAreEqual(first.Senses, second.Senses);
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
                Assert.That(first.IsTrueKanjiReading, Is.EqualTo(second.IsTrueKanjiReading));
                Assert.That(first.Restriction, Is.EqualTo(second.Restriction));
                Assert.That(first.Informations, Is.EqualTo(second.Informations));
                Assert.That(first.Priorities, Is.EqualTo(second.Priorities));
            }
        }

        private static void AssertSensesAreEqual(IEnumerable<ISense> firstList, IEnumerable<ISense> secondList)
        {
            if (firstList.Count() != secondList.Count())
            {
                Assert.Fail("Senses are different lengths");
            }

            for (var i = 0; i < firstList.Count(); i++)
            {
                var first = firstList.ElementAt(i);
                var second = secondList.ElementAt(i);

                Assert.That(first.KanjiRestriction, Is.EqualTo(second.KanjiRestriction));
                Assert.That(first.ReadingRestriction, Is.EqualTo(second.ReadingRestriction));
                Assert.That(first.PartsOfSpeech, Is.EqualTo(second.PartsOfSpeech));
                Assert.That(first.CrossReferences, Is.EqualTo(second.CrossReferences));
                Assert.That(first.Antonyms, Is.EqualTo(second.Antonyms));
                Assert.That(first.Fields, Is.EqualTo(second.Fields));
                Assert.That(first.Miscellanea, Is.EqualTo(second.Miscellanea));
                Assert.That(first.Informations, Is.EqualTo(second.Informations));
                Assert.That(first.LoanwordSources, Is.EqualTo(second.LoanwordSources));
                Assert.That(first.Dialects, Is.EqualTo(second.Dialects));
                Assert.That(first.Glosses, Is.EqualTo(second.Glosses));
            }
        }
    }
}