namespace Wacton.Desu.ExampleConsole
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Wacton.Desu.Japanese;
    using Wacton.Desu.Kanji;
    using Wacton.Desu.Names;
    using Wacton.Desu.Radicals;
    using Wacton.Desu.Strokes;

    public static class ExampleFunctionsAsync
    {
        public static async Task<IEnumerable<IJapaneseEntry>> GetJapaneseEntriesAsync()
        {
            var japaneseDictionary = new JapaneseDictionary();
            var japaneseEntries = await japaneseDictionary.GetEntriesAsync();
            return japaneseEntries;
        }

        public static async Task<IEnumerable<IJapaneseEntry>> ParseJapaneseEntriesAsync()
        {
            var japaneseEntries = await JapaneseDictionary.ParseEntriesAsync();
            return japaneseEntries;
        }

        public static async Task<IEnumerable<INameEntry>> GetNameEntriesAsync()
        {
            var nameDictionary = new NameDictionary();
            var nameEntries = await nameDictionary.GetEntriesAsync();
            return nameEntries;
        }

        public static async Task<IEnumerable<INameEntry>> ParseNameEntriesAsync()
        {
            var nameEntries = await NameDictionary.ParseEntriesAsync();
            return nameEntries;
        }

        public static async Task<IEnumerable<IKanjiEntry>> GetKanjiEntriesAsync()
        {
            var kanjiDictionary = new KanjiDictionary();
            var kanjiEntries = await kanjiDictionary.GetEntriesAsync();
            return kanjiEntries;
        }

        public static async Task<IEnumerable<IKanjiEntry>> ParseKanjiEntriesAsync()
        {
            var kanjiEntries = await KanjiDictionary.ParseEntriesAsync();
            return kanjiEntries;
        }

        public static async Task<IDictionary<string, IEnumerable<string>>> GetKanjiToRadicalsAsync()
        {
            var radicalLookup = new RadicalLookup();
            var kanjiToRadicals = await radicalLookup.GetKanjiToRadicalsAsync();
            return kanjiToRadicals;
        }

        public static async Task<IDictionary<string, IEnumerable<string>>> ParseKanjiToRadicalsAsync()
        {
            var kanjiToRadicals = await RadicalLookup.ParseKanjiToRadicalsAsync();
            return kanjiToRadicals;
        }

        public static async Task<IDictionary<string, IEnumerable<string>>> GetRadicalToKanjisAsync()
        {
            var radicalLookup = new RadicalLookup();
            var radicalToKanjis = await radicalLookup.GetRadicalToKanjisAsync();
            return radicalToKanjis;
        }

        public static async Task<IDictionary<string, IEnumerable<string>>> ParseRadicalToKanjisAsync()
        {
            var radicalToKanjis = await RadicalLookup.ParseRadicalToKanjisAsync();
            return radicalToKanjis;
        }

        public static async Task<IDictionary<string, IEnumerable<string>>> GetKanjiToStrokesAsync()
        {
            var strokeLookup = new StrokeLookup();
            var kanjiToStrokes = await strokeLookup.GetKanjiToStrokesAsync();
            return kanjiToStrokes;
        }

        public static async Task<IDictionary<string, IEnumerable<string>>> ParseKanjiToStrokesAsync()
        {
            var kanjiToStrokes = await StrokeLookup.ParseKanjiToStrokesAsync();
            return kanjiToStrokes;
        }
    }
}