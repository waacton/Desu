namespace Wacton.Desu.Tests.Japanese;

using System.Collections.Generic;
using System.Linq;
using Wacton.Desu.Japanese;
using Wacton.Desu.Tests.Utils;

public static class Assertions
{
    public static void AssertEntry(TestEntry testEntry, IEnumerable<IJapaneseEntry> japaneseEntries)
    {
        var entry = japaneseEntries.Single(x => x.Sequence == testEntry.Sequence);
        AssertEntryEquality(entry, testEntry);
    }
        
    public static void AssertEntryEquality(IJapaneseEntry first, IJapaneseEntry second)
    {
        AssertUtils.AssertPropertyEquality(first, second, x => x.Sequence);
        AssertUtils.AssertListEquality(first.Kanjis, second.Kanjis, AssertKanjiEquality);
        AssertUtils.AssertListEquality(first.Readings, second.Readings, AssertReadingEquality);
        AssertUtils.AssertListEquality(first.Senses, second.Senses, AssertSenseEquality);
        AssertUtils.AssertPropertyEquality(first, second, x => x.ToString());
    }

    private static void AssertKanjiEquality(IKanji first, IKanji second)
    {
        AssertUtils.AssertPropertyEquality(first, second, x => x.Informations);
        AssertUtils.AssertPropertyEquality(first, second, x => x.Priorities);
        AssertUtils.AssertPropertyEquality(first, second, x => x.ToString());
    }
        
    private static void AssertReadingEquality(IReading first, IReading second)
    {
        AssertUtils.AssertPropertyEquality(first, second, x => x.Text);
        AssertUtils.AssertPropertyEquality(first, second, x => x.IsTrueKanjiReading);
        AssertUtils.AssertPropertyEquality(first, second, x => x.Restriction);
        AssertUtils.AssertPropertyEquality(first, second, x => x.Informations);
        AssertUtils.AssertPropertyEquality(first, second, x => x.Priorities);
        AssertUtils.AssertPropertyEquality(first, second, x => x.ToString());
    }
        
    private static void AssertSenseEquality(ISense first, ISense second)
    {
        AssertUtils.AssertPropertyEquality(first, second, x => x.KanjiRestriction);
        AssertUtils.AssertPropertyEquality(first, second, x => x.ReadingRestriction);
        AssertUtils.AssertPropertyEquality(first, second, x => x.PartsOfSpeech);
        AssertUtils.AssertPropertyEquality(first, second, x => x.CrossReferences);
        AssertUtils.AssertPropertyEquality(first, second, x => x.Antonyms);
        AssertUtils.AssertPropertyEquality(first, second, x => x.Fields);
        AssertUtils.AssertPropertyEquality(first, second, x => x.Miscellanea);
        AssertUtils.AssertPropertyEquality(first, second, x => x.Informations);
        AssertUtils.AssertPropertyEquality(first, second, x => x.LoanwordSources);
        AssertUtils.AssertPropertyEquality(first, second, x => x.Dialects);
        AssertUtils.AssertPropertyEquality(first, second, x => x.Glosses);
        AssertUtils.AssertPropertyEquality(first, second, x => x.ToString());
    }
}