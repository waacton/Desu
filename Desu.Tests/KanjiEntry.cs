using NUnit.Framework;
using System.Collections.Generic;
using Wacton.Desu.Kanji;
using Wacton.Desu.Tests.Kanji;

namespace Wacton.Desu.Tests
{
    public class KanjiEntry
    {
        private IEnumerable<IKanjiEntry> kanjiEntries;

        [OneTimeSetUp]
        public void Setup()
        {
            kanjiEntries = KanjiDictionary.ParseEntries();
        }

        [Test]
        public void 䯂() => Assertions.AssertEntry(TestEntries.䯂(), kanjiEntries);

        [Test]
        public void 亀() => Assertions.AssertEntry(TestEntries.亀(), kanjiEntries);

        [Test]
        public void 彁() => Assertions.AssertEntry(TestEntries.彁(), kanjiEntries);

        [Test]
        public void 鰹() => Assertions.AssertEntry(TestEntries.鰹(), kanjiEntries);

        [Test]
        public void 夊() => Assertions.AssertEntry(TestEntries.夊(), kanjiEntries);

        [Test]
        public void 亜() => Assertions.AssertEntry(TestEntries.亜(), kanjiEntries); // first entry in kanjidic2

        [Test]
        public void 頻() => Assertions.AssertEntry(TestEntries.頻(), kanjiEntries); // last entry in kanjidic2
    }
}