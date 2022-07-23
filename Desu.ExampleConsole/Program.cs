namespace Wacton.Desu.ExampleConsole
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Wacton.Desu.Enums;
    using Wacton.Desu.Japanese;
    using Wacton.Desu.Kanji;
    using Wacton.Desu.Names;
    using Wacton.Desu.Romaji;

    public class Program
    {
        private const bool GenerateExampleJson = false;
        private const bool UseAsync = true;
        private static readonly Random Random = new();
        private static readonly Transliterator Transliterator = new();

        public static async Task Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            if (GenerateExampleJson)
            {
                OutputLine("Generating example JSON files...");
                await SaveAsJson.JapaneseEntry();
                await SaveAsJson.NameEntry();
                await SaveAsJson.KanjiEntry();
                await SaveAsJson.RadicalFromKanjiEntry();
                await SaveAsJson.RadicalToKanjiEntry();
                await SaveAsJson.StrokeEntry();
            }

            OutputLine("Getting dictionaries...");
            if (UseAsync)
            {
                await RunAsync();
            }
            else
            {
                RunSync();
            }
        }

        private static async Task RunAsync()
        {
            var japaneseDictionaryStopwatch = new Stopwatch();
            var nameDictionaryStopwatch = new Stopwatch();
            var kanjiDictionaryStopwatch = new Stopwatch();

            japaneseDictionaryStopwatch.Start();
            var japaneseEntries = (await JapaneseDictionary.ParseEntriesAsync()).ToList();
            japaneseDictionaryStopwatch.Stop();

            nameDictionaryStopwatch.Start();
            var nameEntries = (await NameDictionary.ParseEntriesAsync()).ToList();
            nameDictionaryStopwatch.Stop();

            kanjiDictionaryStopwatch.Start();
            var kanjiEntries = (await KanjiDictionary.ParseEntriesAsync()).ToList();
            kanjiDictionaryStopwatch.Stop();

            var japaneseDictionaryCreationDate = await JapaneseDictionary.ParseCreationDateAsync();
            var nameDictionaryCreationDate = await NameDictionary.ParseCreationDateAsync();
            var kanjiDictionaryCreationDate = await KanjiDictionary.ParseCreationDateAsync();

            OutputParseTimes(
                japaneseDictionaryStopwatch.Elapsed, japaneseDictionaryCreationDate, japaneseEntries.Count,
                nameDictionaryStopwatch.Elapsed, nameDictionaryCreationDate, nameEntries.Count,
                kanjiDictionaryStopwatch.Elapsed, kanjiDictionaryCreationDate, kanjiEntries.Count);

            while (true)
            {
                OutputRandomJapaneseEntry(japaneseEntries, kanjiEntries);
            }
        }

        private static void RunSync()
        {
            var japaneseDictionaryStopwatch = new Stopwatch();
            var nameDictionaryStopwatch = new Stopwatch();
            var kanjiDictionaryStopwatch = new Stopwatch();

            japaneseDictionaryStopwatch.Start();
            var japaneseEntries = JapaneseDictionary.ParseEntries().ToList();
            japaneseDictionaryStopwatch.Stop();

            nameDictionaryStopwatch.Start();
            var nameEntries = NameDictionary.ParseEntries().ToList();
            nameDictionaryStopwatch.Stop();

            kanjiDictionaryStopwatch.Start();
            var kanjiEntries = KanjiDictionary.ParseEntries().ToList();
            kanjiDictionaryStopwatch.Stop();

            var japaneseDictionaryCreationDate = JapaneseDictionary.ParseCreationDate();
            var nameDictionaryCreationDate = NameDictionary.ParseCreationDate();
            var kanjiDictionaryCreationDate = KanjiDictionary.ParseCreationDate();

            OutputParseTimes(
                japaneseDictionaryStopwatch.Elapsed, japaneseDictionaryCreationDate, japaneseEntries.Count,
                nameDictionaryStopwatch.Elapsed, nameDictionaryCreationDate, nameEntries.Count,
                kanjiDictionaryStopwatch.Elapsed, kanjiDictionaryCreationDate, kanjiEntries.Count);

            while (true)
            {
                OutputRandomJapaneseEntry(japaneseEntries, kanjiEntries);
            }
        }

        private static void OutputParseTimes(
            TimeSpan japaneseTimeSpan, DateTime japaneseCreationDate, int japaneseCount, 
            TimeSpan nameTimeSpan, DateTime nameCreationDate, int nameCount,
            TimeSpan kanjiTimeSpan, DateTime kanjiCreationDate, int kanjiCount)
        {
            OutputLine(string.Empty);
            OutputLine($"JMdict time to parse: {japaneseTimeSpan}");
            OutputLine($"JMdict created: {japaneseCreationDate.ToShortDateString()}");
            OutputLine($"JMdict entries: {japaneseCount}");
            OutputLine(string.Empty);
            OutputLine($"JMnedict time to parse: {nameTimeSpan}");
            OutputLine($"JMnedict created: {nameCreationDate.ToShortDateString()}");
            OutputLine($"JMnedict entries: {nameCount}");
            OutputLine(string.Empty);
            OutputLine($"kanjidict2 time to parse: {kanjiTimeSpan}");
            OutputLine($"kanjidict2 created: {kanjiCreationDate.ToShortDateString()}");
            OutputLine($"kanjidict2 entries: {kanjiCount}");
            OutputLine(string.Empty);
        }

        private static void OutputRandomJapaneseEntry(IReadOnlyList<IJapaneseEntry> japaneseEntries, IReadOnlyList<IKanjiEntry> kanjiEntries)
        {
            OutputStartEntry();

            var index = Random.Next(0, japaneseEntries.Count);
            var japaneseEntry = japaneseEntries[index];
            var romaji = Transliterator.GetRomaji(japaneseEntry.Readings.First().Text);

            OutputLine($"{index} / {japaneseEntries.Count}");
            OutputLine($"{japaneseEntry} >>> \"{romaji}\" ");

            var firstKanji = japaneseEntry.Kanjis.FirstOrDefault()?.Text;
            if (firstKanji == null)
            {
                OutputEndEntry();
                return;
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

            OutputEndEntry();
        }
        
        private static void OutputLineBreak() => OutputLine("------------------------------");
        private static void OutputStartEntry() => OutputLineBreak();
        private static void OutputEndEntry()
        {
            OutputLineBreak();
            OutputLine(string.Empty);
            Console.ReadKey();
        }

        private static void OutputLine(string text)
        {
            Debug.WriteLine(text);
            Console.WriteLine(text);
        }
    }
}
