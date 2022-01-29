namespace Wacton.Desu.Tests;

using NUnit.Framework;

// instantiating the same object twice to assert value equality with different reference
public class Equality
{
    [Test]
    public void JapaneseEquality() => Japanese.Assertions.AssertEntryEquality(Japanese.TestEntries.FullObject(), Japanese.TestEntries.FullObject());
    
    [Test]
    public void NameEquality() => Names.Assertions.AssertEntryEquality(Names.TestEntries.FullObject(), Names.TestEntries.FullObject());
    
    [Test]
    public void KanjiEquality() => Kanji.Assertions.AssertEntryEquality(Kanji.TestEntries.FullObject(), Kanji.TestEntries.FullObject());
}