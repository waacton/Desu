namespace Wacton.Desu.Example
{
    using System;
    using System.Diagnostics;
    using System.Linq;

    using Wacton.Desu.Enums;
    using Wacton.Desu.Japanese;
    using Wacton.Desu.Kanji;
    using Wacton.Tovarisch.Collections;

    public class Program
    {
        public static void Main(string[] args)
        {
            var japaneseDictionaryStopwatch = new Stopwatch();
            var kanjiDictionaryStopwatch = new Stopwatch();

            japaneseDictionaryStopwatch.Start();
            var japaneseDictionary = new JapaneseDictionary();
            var japaneseEntries = japaneseDictionary.GetEntries().ToList();
            japaneseDictionaryStopwatch.Stop();

            kanjiDictionaryStopwatch.Start();
            var kanjiDictionary = new KanjiDictionary();
            var kanjiEntries = kanjiDictionary.GetEntries().ToList();
            kanjiDictionaryStopwatch.Stop();

            Debug.WriteLine("____________________");

            Debug.WriteLine($"Time to parse JMdict: {japaneseDictionaryStopwatch.Elapsed}");
            Debug.WriteLine($"Time to parse kanjidict2: {kanjiDictionaryStopwatch.Elapsed}");

            Debug.WriteLine("~~~ ~~~ ~~~ ~~~ ~~~");

            var japaneseDictionaryCreationDate = japaneseDictionary.CreationDate;
            Debug.WriteLine($"JMdict created: {japaneseDictionaryCreationDate.ToShortDateString()}");

            var kanjiDictionaryCreationDate = kanjiDictionary.CreationDate;
            Debug.WriteLine($"kanjidict2 created: {kanjiDictionaryCreationDate.ToShortDateString()}");

            var random = new Random();
            for (var i = 0; i < 100; i++)
            {
                Debug.WriteLine("~~~ ~~~ ~~~ ~~~ ~~~");

                var index = random.Next(0, japaneseEntries.Count);
                var entry = japaneseEntries[index];

                Debug.WriteLine($"{index} / {japaneseEntries.Count}");
                Debug.WriteLine(entry);

                var firstKanji = entry.Kanjis.FirstOrDefault()?.Text;
                if (firstKanji == null)
                {
                    continue;
                }

                foreach (var character in firstKanji)
                {
                    var kanjiReference = kanjiEntries.SingleOrDefault(kanjiEntry => kanjiEntry.Literal.Equals(character.ToString()));
                    if (kanjiReference == null)
                    {
                        continue;
                    }

                    var literal = kanjiReference.Literal;
                    var radicalDecomposition = kanjiReference.RadicalDecomposition.ToDelimitedString(" ");
                    var kanjiMeaning = !kanjiReference.Meanings.Any() ? string.Empty : kanjiReference.Meanings.First(meaning => meaning.Language.Equals(Language.English)).Term;
                    Debug.WriteLine($"{literal} -> {radicalDecomposition} ({kanjiMeaning})");
                }
            }

            Debug.WriteLine("~~~ ~~~ ~~~ ~~~ ~~~");
        }
    }
}
