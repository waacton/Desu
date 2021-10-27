using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;
using Wacton.Desu.Japanese;
using Wacton.Desu.Tests.Japanese;

namespace Wacton.Desu.Tests
{
    public class JapaneseEntryAsync
    {
        private IEnumerable<IJapaneseEntry> japaneseEntries;

        [OneTimeSetUp]
        public async Task Setup()
        {
            japaneseEntries = await JapaneseDictionary.ParseEntriesAsync();
        }

        [Test]
        public void 食べる() => JapaneseAssert.AssertEntry(TestEntries.食べる(), japaneseEntries);

        [Test]
        public void 々() => JapaneseAssert.AssertEntry(TestEntries.々(), japaneseEntries);

        [Test]
        public void βカロテン() => JapaneseAssert.AssertEntry(TestEntries.βカロテン(), japaneseEntries);

        [Test]
        public void Withコロナ() => JapaneseAssert.AssertEntry(TestEntries.Withコロナ(), japaneseEntries);

        [Test]
        public void サーターアンダギー() => JapaneseAssert.AssertEntry(TestEntries.サーターアンダギー(), japaneseEntries);

        [Test]
        public void 九百() => JapaneseAssert.AssertEntry(TestEntries.九百(), japaneseEntries);

        [Test]
        public void タチ() => JapaneseAssert.AssertEntry(TestEntries.タチ(), japaneseEntries);

        [Test]
        public void コンビナートキャンペーン() => JapaneseAssert.AssertEntry(TestEntries.コンビナートキャンペーン(), japaneseEntries);

        [Test]
        public void ヽ() => JapaneseAssert.AssertEntry(TestEntries.ヽ(), japaneseEntries); // first entry in JMdict
    }
}