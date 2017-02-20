namespace Wacton.Desu.Example
{
    using System;
    using System.Diagnostics;
    using System.Linq;

    using Wacton.Desu.Kanjidict;
    using Wacton.Tovarisch.Collections;

    public class Program
    {
        public static void Main(string[] args)
        {
            var jmDictStopwatch = new Stopwatch();
            var kanjiDictStopwatch = new Stopwatch();

            jmDictStopwatch.Start();
            var dictionary = new JapaneseDictionary();
            var entries = dictionary.GetEntries().ToList();
            jmDictStopwatch.Stop();

            kanjiDictStopwatch.Start();
            var kanjiDict = new KanjiDictionary();
            var kanjiEntries = kanjiDict.GetEntries().ToList();
            kanjiDictStopwatch.Stop();

            Debug.WriteLine("____________________");

            Debug.WriteLine($"Time to parse JMdict: {jmDictStopwatch.Elapsed}");
            Debug.WriteLine($"Time to parse kanjidict2: {kanjiDictStopwatch.Elapsed}");

            Debug.WriteLine("~~~ ~~~ ~~~ ~~~ ~~~");

            var japaneseDictionaryCreationDate = dictionary.CreationDate;
            Debug.WriteLine($"JMdict created: {japaneseDictionaryCreationDate.ToShortDateString()}");

            var kanjiDictionaryCreationDate = kanjiDict.CreationDate;
            Debug.WriteLine($"kanjidict2 created: {kanjiDictionaryCreationDate.ToShortDateString()}");

            var random = new Random();
            for (var i = 0; i < 100; i++)
            {
                Debug.WriteLine("~~~ ~~~ ~~~ ~~~ ~~~");

                var index = random.Next(0, entries.Count);
                var entry = entries[index];

                Debug.WriteLine($"{index} / {entries.Count}");
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
