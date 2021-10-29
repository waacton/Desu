using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using Wacton.Desu.Kanji;
using Wacton.Desu.Tests.Kanji;

namespace Wacton.Desu.Tests
{
    public static class KanjiAssert
    {
        public static void AssertEntry(TestEntry testEntry, IEnumerable<IKanjiEntry> kanjiEntries)
        {
            var entry = kanjiEntries.Single(x => x.Literal == testEntry.Literal);
            AssertEntriesAreEqual(entry, testEntry);
        }

        private static void AssertEntriesAreEqual(IKanjiEntry first, IKanjiEntry second)
        {
            Assert.That(first.Literal, Is.EqualTo(second.Literal));
            Assert.That(first.RadicalDecomposition, Is.EqualTo(second.RadicalDecomposition));
            Assert.That(first.Codepoints, Is.EqualTo(second.Codepoints));
            Assert.That(first.StrokePaths, Is.EqualTo(second.StrokePaths));
            Assert.That(first.IndexRadicals, Is.EqualTo(second.IndexRadicals));
            Assert.That(first.IsIndexRadical, Is.EqualTo(second.IsIndexRadical));
            Assert.That(first.Grade, Is.EqualTo(second.Grade));
            Assert.That(first.StrokeCount, Is.EqualTo(second.StrokeCount));
            Assert.That(first.StrokeCommonMiscounts, Is.EqualTo(second.StrokeCommonMiscounts));
            Assert.That(first.Variants, Is.EqualTo(second.Variants));
            Assert.That(first.Frequency, Is.EqualTo(second.Frequency));
            Assert.That(first.RadicalNames, Is.EqualTo(second.RadicalNames));
            Assert.That(first.JLPT, Is.EqualTo(second.JLPT));
            Assert.That(first.References, Is.EqualTo(second.References));
            Assert.That(first.QueryCodes, Is.EqualTo(second.QueryCodes));
            Assert.That(first.Readings, Is.EqualTo(second.Readings));
            Assert.That(first.Meanings, Is.EqualTo(second.Meanings));
            Assert.That(first.Nanoris, Is.EqualTo(second.Nanoris));
        }
    }
}