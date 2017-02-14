namespace Wacton.Desu.Example
{
    using System;
    using System.Diagnostics;
    using System.Linq;

    using Wacton.Desu.Kanjidict;

    public class Program
    {
        public static void Main(string[] args)
        {
            var kanjiDict = new KanjiDictionary();
            var kanjiEntries = kanjiDict.GetEntries();

            var dictionary = new JapaneseDictionary();
            var entries = dictionary.GetEntries().ToList();

            var index = new Random().Next(0, entries.Count);
            var entry = entries[43];
            
            var kanji = entry.Kanjis.First().Text[0].ToString();
            var kanjiReference = kanjiEntries.Single(kanjiEntry => kanjiEntry.Literal.Equals(kanji));

            Debug.WriteLine($"{index} / {entries.Count}");
            Debug.WriteLine(entry);

            var creationDate = dictionary.CreationDate;
            Debug.WriteLine($"JMdict created: {creationDate.ToShortDateString()}");
        }
    }
}
