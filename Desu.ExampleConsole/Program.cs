namespace Wacton.Desu.ExampleConsole
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using Wacton.Desu.Enums;
    using Wacton.Desu.Japanese;
    using Wacton.Desu.Kanji;
    using Wacton.Desu.Names;
    using Wacton.Desu.Romaji;

    public class Program
    {
        public static void Main()
        {
            var japaneseDictionaryStopwatch = new Stopwatch();
            var kanjiDictionaryStopwatch = new Stopwatch();
            var nameDictionaryStopwatch = new Stopwatch();

            Console.OutputEncoding = Encoding.UTF8;
            OutputLine("Getting dictionaries...");

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

            OutputLine("____________________");
            OutputLine($"Time to parse JMdict: {japaneseDictionaryStopwatch.Elapsed}");
            OutputLine($"Time to parse kanjidict2: {kanjiDictionaryStopwatch.Elapsed}");
            OutputLine($"Time to parse JMnedict: {nameDictionaryStopwatch.Elapsed}");


            var japaneseDictionaryCreationDate = japaneseDictionary.CreationDate;
            OutputLine("____________________");
            OutputLine($"JMdict created: {japaneseDictionaryCreationDate.ToShortDateString()}");
            OutputLine($"JMdict entries: {japaneseEntries.Count}");

            var kanjiDictionaryCreationDate = kanjiDictionary.CreationDate;
            OutputLine("____________________");
            OutputLine($"kanjidict2 created: {kanjiDictionaryCreationDate.ToShortDateString()}");
            OutputLine($"kanjidict2 entries: {kanjiEntries.Count}");

            var nameDictionaryCreationDate = nameDictionary.CreationDate;
            OutputLine("____________________");
            OutputLine($"JMnedict created: {nameDictionaryCreationDate.ToShortDateString()}");
            OutputLine($"JMnedict entries: {nameEntries.Count}");

            var transliterator = new Transliterator();
            var random = new Random();

            var isFinished = false;
            while (!isFinished)
            {
                OutputLine("~~~ ~~~ ~~~ ~~~ ~~~");

                var index = random.Next(0, japaneseEntries.Count);
                var japaneseEntry = japaneseEntries[index];
                var romaji = transliterator.GetRomaji(japaneseEntry.Readings.First().Text);

                OutputLine($"{index} / {japaneseEntries.Count}");
                OutputLine($"{japaneseEntry} >>> \"{romaji}\" ");

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
                    OutputLine($"{literal} -> {radicalDecomposition} ({kanjiMeaning})");
                }

                OutputLine("~~~ ~~~ ~~~ ~~~ ~~~");
                OutputLine(string.Empty);
                Console.ReadKey();
            }
        }

        private static void OutputLine(string text)
        {
            Debug.WriteLine(text);
            Console.WriteLine(text);
        }
    }
}
