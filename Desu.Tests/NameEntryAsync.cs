using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;
using Wacton.Desu.Names;
using Wacton.Desu.Tests.Names;

namespace Wacton.Desu.Tests
{
    public class NameEntryAsync
    {
        private IEnumerable<INameEntry> nameEntries;

        [OneTimeSetUp]
        public async Task Setup()
        {
            nameEntries = await NameDictionary.ParseEntriesAsync();
        }

        [Test]
        public void 国語研究所() => NameAssert.AssertEntry(TestEntries.国語研究所(), nameEntries);

        [Test]
        public void ガラパゴス() => NameAssert.AssertEntry(TestEntries.ガラパゴス(), nameEntries);

        [Test]
        public void 国労() => NameAssert.AssertEntry(TestEntries.国労(), nameEntries); // first entry in JMnedict
    }
}