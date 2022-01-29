namespace Wacton.Desu.Tests;

using System.Collections.Generic;
using System.Threading.Tasks;
using NUnit.Framework;
using Wacton.Desu.Names;
using Wacton.Desu.Tests.Names;

public class NameEntryAsync
{
    private IEnumerable<INameEntry> nameEntries;

    [OneTimeSetUp]
    public async Task Setup()
    {
        nameEntries = await NameDictionary.ParseEntriesAsync();
    }

    [Test]
    public void 国語研究所() => Assertions.AssertEntry(TestEntries.国語研究所(), nameEntries);

    [Test]
    public void ガラパゴス() => Assertions.AssertEntry(TestEntries.ガラパゴス(), nameEntries);

    [Test]
    public void 国労() => Assertions.AssertEntry(TestEntries.国労(), nameEntries); // first entry in JMnedict
}