namespace Wacton.Desu.Tests.Kanji;

using System.Collections.Generic;
using System.Linq;
using Wacton.Desu.Kanji;
using Wacton.Desu.Tests.Utils;

public static class Assertions
{
    public static void AssertEntry(TestEntry testEntry, IEnumerable<IKanjiEntry> kanjiEntries)
    {
        var entry = kanjiEntries.Single(x => x.Literal == testEntry.Literal);
        AssertEntryEquality(entry, testEntry);
    }

    public static void AssertEntryEquality(IKanjiEntry first, IKanjiEntry second)
    {
        AssertUtils.AssertPropertyEquality(first, second, x => x.Literal);
        AssertUtils.AssertPropertyEquality(first, second, x => x.RadicalDecomposition);
        AssertUtils.AssertPropertyEquality(first, second, x => x.Codepoints);
        AssertUtils.AssertPropertyEquality(first, second, x => x.StrokePaths);
        AssertUtils.AssertPropertyEquality(first, second, x => x.IndexRadicals);
        AssertUtils.AssertPropertyEquality(first, second, x => x.IsIndexRadical);
        AssertUtils.AssertPropertyEquality(first, second, x => x.Grade);
        AssertUtils.AssertPropertyEquality(first, second, x => x.StrokeCount);
        AssertUtils.AssertPropertyEquality(first, second, x => x.StrokeCommonMiscounts);
        AssertUtils.AssertPropertyEquality(first, second, x => x.Variants);
        AssertUtils.AssertPropertyEquality(first, second, x => x.Frequency);
        AssertUtils.AssertPropertyEquality(first, second, x => x.RadicalNames);
        AssertUtils.AssertPropertyEquality(first, second, x => x.JLPT);
        AssertUtils.AssertPropertyEquality(first, second, x => x.References);
        AssertUtils.AssertPropertyEquality(first, second, x => x.QueryCodes);
        AssertUtils.AssertPropertyEquality(first, second, x => x.Readings);
        AssertUtils.AssertPropertyEquality(first, second, x => x.Meanings);
        AssertUtils.AssertPropertyEquality(first, second, x => x.Nanoris);
        AssertUtils.AssertPropertyEquality(first, second, x => x.ToString());
    }
}