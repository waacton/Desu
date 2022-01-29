namespace Wacton.Desu.Tests;

using System.Collections.Generic;
using NUnit.Framework;
using Wacton.Desu.Radicals;
using Wacton.Desu.Tests.Radicals;

public class RadicalEntry
{
    private IDictionary<string, IEnumerable<string>> kanjiToRadicals;
    private IDictionary<string, IEnumerable<string>> radicalToKanjis;

    [OneTimeSetUp]
    public void Setup()
    {
        kanjiToRadicals = RadicalLookup.ParseKanjiToRadicals();
        radicalToKanjis = RadicalLookup.ParseRadicalToKanjis();
    }

    [Test]
    public void Kanji䯂() => Assertions.AssertList(TestEntries.Kanji䯂(), () => kanjiToRadicals["䯂"]);

    [Test]
    public void Kanji亀() => Assertions.AssertList(TestEntries.Kanji亀(), () => kanjiToRadicals["亀"]);

    [Test]
    public void Kanji彁() => Assertions.AssertList(TestEntries.Kanji彁(), () => kanjiToRadicals["彁"]);

    [Test]
    public void Kanji鰹() => Assertions.AssertList(TestEntries.Kanji鰹(), () => kanjiToRadicals["鰹"]);

    [Test]
    public void Kanji夊() => Assertions.AssertList(TestEntries.Kanji夊(), () => kanjiToRadicals["夊"]);

    [Test]
    public void Kanji買() => Assertions.AssertList(TestEntries.Kanji買(), () => kanjiToRadicals["買"]);

    [Test]
    public void Kanji乞() => Assertions.AssertList(TestEntries.Kanji乞(), () => kanjiToRadicals["乞"]);

    [Test]
    public void Kanji亜() => Assertions.AssertList(TestEntries.Kanji亜(), () => kanjiToRadicals["亜"]); // first entry in kradfile

    [Test]
    public void Kanji熙() => Assertions.AssertList(TestEntries.Kanji熙(), () => kanjiToRadicals["熙"]); // last entry in kradfile

    [Test]
    public void Kanji丂() => Assertions.AssertList(TestEntries.Kanji丂(), () => kanjiToRadicals["丂"]); // first entry in kradfile2

    [Test]
    public void Kanji龥() => Assertions.AssertList(TestEntries.Kanji龥(), () => kanjiToRadicals["龥"]); // last entry in kradfile2

    [Test]
    public void Radical一() => Assertions.AssertList(TestEntries.Radical一(), () => radicalToKanjis["一"]); // first entry in radkfilex
        
    [Test]
    public void Radical囗() => Assertions.AssertList(TestEntries.Radical囗(), () => radicalToKanjis["囗"]);

    [Test]
    public void Radical亀() => Assertions.AssertList(TestEntries.Radical亀(), () => radicalToKanjis["亀"]);

    [Test]
    public void Radical鬯() => Assertions.AssertList(TestEntries.Radical鬯(), () => radicalToKanjis["鬯"]);

    [Test]
    public void Radical買() => Assertions.AssertList(TestEntries.Radical買(), () => radicalToKanjis["買"]);

    [Test]
    public void RadicalU2EB2() => Assertions.AssertList(TestEntries.RadicalU2EB2(), () => radicalToKanjis["⺲"]);

    [Test]
    public void Radical乞() => Assertions.AssertList(TestEntries.Radical乞(), () => radicalToKanjis["乞"]);

    [Test]
    public void RadicalU20089() => Assertions.AssertList(TestEntries.RadicalU20089(), () => radicalToKanjis["𠂉"]);

    [Test]
    public void Radical龠() => Assertions.AssertList(TestEntries.Radical龠(), () => radicalToKanjis["龠"]); // last entry in radkfilex

    [Test]
    public void Radical䯂() => Assertions.AssertList(TestEntries.Radical䯂(), () => radicalToKanjis["䯂"]);
}