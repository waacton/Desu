namespace Wacton.Desu.ExampleConsole
{
    using System.Collections.Generic;

    using Wacton.Desu.Japanese;
    using Wacton.Desu.Kanji;
    using Wacton.Desu.Names;
    using Wacton.Desu.Radicals;
    using Wacton.Desu.Romaji;
    using Wacton.Desu.Strokes;

    public static class ExampleFunctions
    {
        public static IEnumerable<IJapaneseEntry> GetJapaneseEntries()
        {
            var japaneseDictionary = new JapaneseDictionary();
            var japaneseEntries = japaneseDictionary.GetEntries();
            return japaneseEntries;
        }

        public static IEnumerable<IKanjiEntry> GetKanjiEntries()
        {
            var kanjiDictionary = new KanjiDictionary();
            var kanjiEntries = kanjiDictionary.GetEntries();
            return kanjiEntries;
        }

        public static IEnumerable<INameEntry> GetNameEntries()
        {
            var nameDictionary = new NameDictionary();
            var nameEntries = nameDictionary.GetEntries();
            return nameEntries;
        }

        public static IDictionary<string, List<string>> GetKanjiToRadicals()
        {
            var radicalLookup = new RadicalLookup();
            var kanjiToRadicals = radicalLookup.GetKanjiToRadicals();
            return kanjiToRadicals;
        }

        public static IDictionary<string, List<string>> GetRadicalToKanjis()
        {
            var radicalLookup = new RadicalLookup();
            var radicalToKanjis = radicalLookup.GetRadicalToKanjis();
            return radicalToKanjis;
        }

        public static IDictionary<string, List<string>> GetKanjiToStrokes()
        {
            var strokeLookup = new StrokeLookup();
            var kanjiToStrokes = strokeLookup.GetKanjiToStrokes();
            return kanjiToStrokes;
        }

        public static string GetRomaji()
        {
            var transliterator = new Transliterator();
            var romaji = transliterator.GetRomaji("です"); // romaji == "desu"
            return romaji;
        }
    }
}