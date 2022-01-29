namespace Wacton.Desu.Tests;

using System.Collections.Generic;
using System.Threading.Tasks;
using NUnit.Framework;
using Wacton.Desu.Kanji;
using Wacton.Desu.Tests.Kanji;

public class KanjiEntryAsync
{
    private IEnumerable<IKanjiEntry> kanjiEntries;

    [OneTimeSetUp]
    public async Task Setup()
    {
        kanjiEntries = await KanjiDictionary.ParseEntriesAsync();
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