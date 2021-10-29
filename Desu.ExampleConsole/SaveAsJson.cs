namespace Wacton.Desu.ExampleConsole
{
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Wacton.Desu.Japanese;
    using Wacton.Desu.Kanji;
    using Wacton.Desu.Names;
    using Wacton.Desu.Radicals;
    using Wacton.Desu.Strokes;

    public static class SaveAsJson
    {
        public static async Task JapaneseEntry()
        {
            var entries = await JapaneseDictionary.ParseEntriesAsync();
            var entry = entries.Single(x => x.Sequence == 1175570); // {#1175570 :: 円 · 圓 · えん · yen (Japanese monetary unit)}
            Save(entry, "japanese-entry.json");
        }

        public static async Task NameEntry()
        {
            var entries = await NameDictionary.ParseEntriesAsync();
            var entry = entries.Single(x => x.Sequence == 5142901); // {#5142901 :: 円 · えん · En}
            Save(entry, "name-entry.json");
        }

        public static async Task KanjiEntry()
        {
            var entries = await KanjiDictionary.ParseEntriesAsync();
            var entry = entries.Single(x => x.Literal == "円"); // {円 · circle · yen · round}
            Save(entry, "kanji-entry.json");
        }

        public static async Task RadicalFromKanjiEntry()
        {
            var entries = await RadicalLookup.ParseKanjiToRadicalsAsync();
            var entry = entries["円"]; // 円 --> [冂,亠,一,｜]
            Save(entry, "radical-from-kanji-entry.json");
        }

        public static async Task RadicalToKanjiEntry()
        {
            var entries = await RadicalLookup.ParseRadicalToKanjisAsync();
            var entry = entries["冂"]; // 冂, the index radical of 円
            Save(entry, "radical-to-kanji-entry.json");
        }

        public static async Task StrokeEntry()
        {
            var entries = await StrokeLookup.ParseKanjiToStrokesAsync();
            var entry = entries["05186"]; // 05186, the 5-digit unicode number of 円
            Save(entry, "stroke-entry.json");
        }

        private static void Save(object obj, string filename)
        {
            var json = JsonConvert.SerializeObject(obj);
            File.WriteAllLines(filename, new [] { json });
        }
    }
}