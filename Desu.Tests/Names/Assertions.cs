namespace Wacton.Desu.Tests.Names;

using System.Collections.Generic;
using System.Linq;
using Wacton.Desu.Names;
using Wacton.Desu.Tests.Utils;

public static class Assertions
{
    public static void AssertEntry(TestEntry testEntry, IEnumerable<INameEntry> nameEntries)
    {
        var entry = nameEntries.Single(x => x.Sequence == testEntry.Sequence);
        AssertEntryEquality(entry, testEntry);
    }

    public static void AssertEntryEquality(INameEntry first, INameEntry second)
    {
        AssertUtils.AssertPropertyEquality(first, second, x => x.Sequence);
        AssertUtils.AssertListEquality(first.Kanjis, second.Kanjis, AssertKanjiEquality);
        AssertUtils.AssertListEquality(first.Readings, second.Readings, AssertReadingEquality);
        AssertUtils.AssertListEquality(first.Translations, second.Translations, AssertTranslationEquality);
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
        AssertUtils.AssertPropertyEquality(first, second, x => x.Restriction);
        AssertUtils.AssertPropertyEquality(first, second, x => x.Informations);
        AssertUtils.AssertPropertyEquality(first, second, x => x.Priorities);
        AssertUtils.AssertPropertyEquality(first, second, x => x.ToString());
    }

    private static void AssertTranslationEquality(ITranslation first, ITranslation second)
    {
        AssertUtils.AssertPropertyEquality(first, second, x => x.NameTypes);
        AssertUtils.AssertPropertyEquality(first, second, x => x.CrossReferences);
        AssertUtils.AssertPropertyEquality(first, second, x => x.Transcriptions);
        AssertUtils.AssertPropertyEquality(first, second, x => x.ToString());
    }
}