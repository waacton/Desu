using NUnit.Framework;
using System.Collections.Generic;
using Wacton.Desu.Radicals;
using Wacton.Desu.Tests.Radicals;

namespace Wacton.Desu.Tests
{
    public class RadicalEntry
    {
        private IDictionary<string, IEnumerable<string>> kanjiToRadicals;
        private IDictionary<string, IEnumerable<string>> radicalToKanjis;

        [OneTimeSetUp]
        public void Setup()
        {
            kanjiToRadicals = RadicalLookup.ParseKanjiToRadicals();
            radicalToKanjis = RadicalLookup.ParseRadicalToKanjis();
        }

        [Test]
        public void Kanji䯂() => RadicalAssert.AssertList(TestEntries.Kanji䯂(), () => kanjiToRadicals["䯂"]);

        [Test]
        public void Kanji亀() => RadicalAssert.AssertList(TestEntries.Kanji亀(), () => kanjiToRadicals["亀"]);

        [Test]
        public void Kanji彁() => RadicalAssert.AssertList(TestEntries.Kanji彁(), () => kanjiToRadicals["彁"]);

        [Test]
        public void Kanji鰹() => RadicalAssert.AssertList(TestEntries.Kanji鰹(), () => kanjiToRadicals["鰹"]);

        [Test]
        public void Kanji夊() => RadicalAssert.AssertList(TestEntries.Kanji夊(), () => kanjiToRadicals["夊"]);

        [Test]
        public void Kanji亜() => RadicalAssert.AssertList(TestEntries.Kanji亜(), () => kanjiToRadicals["亜"]); // first entry in kradfile

        [Test]
        public void Kanji熙() => RadicalAssert.AssertList(TestEntries.Kanji熙(), () => kanjiToRadicals["熙"]); // last entry in kradfile

        [Test]
        public void Kanji丂() => RadicalAssert.AssertList(TestEntries.Kanji丂(), () => kanjiToRadicals["丂"]); // first entry in kradfile2

        [Test]
        public void Kanji龥() => RadicalAssert.AssertList(TestEntries.Kanji龥(), () => kanjiToRadicals["龥"]); // last entry in kradfile2

        [Test]
        public void Radical一() => RadicalAssert.AssertList(TestEntries.Radical一(), () => radicalToKanjis["一"]); // first entry in radkfilex
        
        [Test]
        public void Radical囗() => RadicalAssert.AssertList(TestEntries.Radical囗(), () => radicalToKanjis["囗"]);

        [Test]
        public void Radical亀() => RadicalAssert.AssertList(TestEntries.Radical亀(), () => radicalToKanjis["亀"]);

        [Test]
        public void Radical鬯() => RadicalAssert.AssertList(TestEntries.Radical鬯(), () => radicalToKanjis["鬯"]);

        [Test]
        public void Radical龠() => RadicalAssert.AssertList(TestEntries.Radical龠(), () => radicalToKanjis["龠"]); // last entry in radkfilex

        [Test]
        public void Radical䯂() => RadicalAssert.AssertList(TestEntries.Radical䯂(), () => radicalToKanjis["䯂"]);
    }
}