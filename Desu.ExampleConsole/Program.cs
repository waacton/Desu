namespace Wacton.Desu.ExampleConsole
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    using Radicals;

    using Strokes;

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
                var japaneseEntry = japaneseEntries[index];

                Debug.WriteLine($"{index} / {japaneseEntries.Count}");
                Debug.WriteLine(japaneseEntry);

                var firstKanji = japaneseEntry.Kanjis.FirstOrDefault()?.Text;
                if (firstKanji == null)
                {
                    continue;
                }

                foreach (var character in firstKanji)
                {
                    var kanjiEntry = kanjiEntries.SingleOrDefault(kanji => kanji.Literal.Equals(character.ToString()));
                    if (kanjiEntry == null)
                    {
                        continue;
                    }

                    var literal = kanjiEntry.Literal;
                    var radicalDecomposition = kanjiEntry.RadicalDecomposition.ToDelimitedString(" ");
                    var kanjiMeaning = !kanjiEntry.Meanings.Any() ? string.Empty : kanjiEntry.Meanings.First(meaning => meaning.Language.Equals(Language.English)).Term;
                    Debug.WriteLine($"{literal} -> {radicalDecomposition} ({kanjiMeaning})");
                }
            }

            Debug.WriteLine("~~~ ~~~ ~~~ ~~~ ~~~");
        }

        private static IEnumerable<IJapaneseEntry> GetJapaneseEntries()
        {
            var japaneseDictionary = new JapaneseDictionary();
            var japaneseEntries = japaneseDictionary.GetEntries();
            return japaneseEntries;
        }

        private static IEnumerable<IKanjiEntry> GetKanjiEntries()
        {
            var kanjiDictionary = new KanjiDictionary();
            var kanjiEntries = kanjiDictionary.GetEntries();
            return kanjiEntries;
        }

        private static IDictionary<string, List<string>> GetKanjiToRadicals()
        {
            var radicalLookup = new RadicalLookup();
            var kanjiToRadicals = radicalLookup.GetKanjiToRadicals();
            return kanjiToRadicals;
        }

        private static IDictionary<string, List<string>> GetRadicalToKanjis()
        {
            var radicalLookup = new RadicalLookup();
            var radicalToKanjis = radicalLookup.GetRadicalToKanjis();
            return radicalToKanjis;
        }

        private static IDictionary<string, List<string>> GetKanjiToStrokes()
        {
            var strokeLookup = new StrokeLookup();
            var kanjiToStrokes = strokeLookup.GetKanjiToStrokes();
            return kanjiToStrokes;
        }
    }
}
