namespace Wacton.Desu.Tests;

using System.Collections.Generic;
using NUnit.Framework;
using Wacton.Desu.Japanese;
using Wacton.Desu.Tests.Japanese;

public class JapaneseEntry
{
    private IEnumerable<IJapaneseEntry> japaneseEntries;

    [OneTimeSetUp]
    public void Setup()
    {
        japaneseEntries = JapaneseDictionary.ParseEntries();
    }

    [Test]
    public void 食べる() => Assertions.AssertEntry(TestEntries.食べる(), japaneseEntries);

    [Test]
    public void 々() => Assertions.AssertEntry(TestEntries.々(), japaneseEntries);

    [Test]
    public void βカロテン() => Assertions.AssertEntry(TestEntries.βカロテン(), japaneseEntries);

    [Test]
    public void Withコロナ() => Assertions.AssertEntry(TestEntries.Withコロナ(), japaneseEntries);

    [Test]
    public void サーターアンダギー() => Assertions.AssertEntry(TestEntries.サーターアンダギー(), japaneseEntries);

    [Test]
    public void 九百() => Assertions.AssertEntry(TestEntries.九百(), japaneseEntries);
        
    [Test]
    public void 蘇格蘭() => Assertions.AssertEntry(TestEntries.蘇格蘭(), japaneseEntries);
        
    [Test]
    public void 羊水() => Assertions.AssertEntry(TestEntries.羊水(), japaneseEntries);

    [Test]
    public void タチ() => Assertions.AssertEntry(TestEntries.タチ(), japaneseEntries);

    [Test]
    public void コンビナートキャンペーン() => Assertions.AssertEntry(TestEntries.コンビナートキャンペーン(), japaneseEntries);

    [Test]
    public void ヽ() => Assertions.AssertEntry(TestEntries.ヽ(), japaneseEntries); // first entry in JMdict
}