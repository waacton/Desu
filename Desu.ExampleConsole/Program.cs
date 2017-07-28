namespace Wacton.Desu.ExampleConsole
{
    using System;
    using System.Diagnostics;
    using System.Linq;

    using Wacton.Desu.Enums;
    using Wacton.Desu.Japanese;
    using Wacton.Desu.Kanji;
    using Wacton.Desu.Names;
    using Wacton.Desu.Romaji;

    public class Program
    {
        public static void Main(string[] args)
        {
            var japaneseDictionaryStopwatch = new Stopwatch();
            var kanjiDictionaryStopwatch = new Stopwatch();
            var nameDictionaryStopwatch = new Stopwatch();

            japaneseDictionaryStopwatch.Start();
            var japaneseDictionary = new JapaneseDictionary();
            var japaneseEntries = japaneseDictionary.GetEntries().ToList();
            japaneseDictionaryStopwatch.Stop();

            kanjiDictionaryStopwatch.Start();
            var kanjiDictionary = new KanjiDictionary();
            var kanjiEntries = kanjiDictionary.GetEntries().ToList();
            kanjiDictionaryStopwatch.Stop();

            nameDictionaryStopwatch.Start();
            var nameDictionary = new NameDictionary();
            var nameEntries = nameDictionary.GetEntries().ToList();
            nameDictionaryStopwatch.Stop();

            Debug.WriteLine("____________________");

            Debug.WriteLine($"Time to parse JMdict: {japaneseDictionaryStopwatch.Elapsed}");
            Debug.WriteLine($"Time to parse kanjidict2: {kanjiDictionaryStopwatch.Elapsed}");
            Debug.WriteLine($"Time to parse JMnedict: {nameDictionaryStopwatch.Elapsed}");

            Debug.WriteLine("~~~ ~~~ ~~~ ~~~ ~~~");

            var japaneseDictionaryCreationDate = japaneseDictionary.CreationDate;
            Debug.WriteLine($"JMdict created: {japaneseDictionaryCreationDate.ToShortDateString()}");

            var kanjiDictionaryCreationDate = kanjiDictionary.CreationDate;
            Debug.WriteLine($"kanjidict2 created: {kanjiDictionaryCreationDate.ToShortDateString()}");

            var nameDictionaryCreationDate = nameDictionary.CreationDate;
            Debug.WriteLine($"JMnedict created: {nameDictionaryCreationDate.ToShortDateString()}");

            var transliterator = new Transliterator();

            var random = new Random();
            for (var i = 0; i < 100; i++)
            {
                Debug.WriteLine("~~~ ~~~ ~~~ ~~~ ~~~");

                var index = random.Next(0, japaneseEntries.Count);
                var japaneseEntry = japaneseEntries[index];
                var romaji = transliterator.GetRomaji(japaneseEntry.Readings.First().Text);

                Debug.WriteLine($"{index} / {japaneseEntries.Count}");
                Debug.WriteLine($"{japaneseEntry} >>> \"{romaji}\" ");

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
                    var radicalDecomposition = string.Join(" ", kanjiEntry.RadicalDecomposition);
                    var kanjiMeaning = !kanjiEntry.Meanings.Any() ? string.Empty : kanjiEntry.Meanings.First(meaning => meaning.Language.Equals(Language.English)).Term;
                    Debug.WriteLine($"{literal} -> {radicalDecomposition} ({kanjiMeaning})");
                }
            }

            Debug.WriteLine("~~~ ~~~ ~~~ ~~~ ~~~");
        }
    }
}
