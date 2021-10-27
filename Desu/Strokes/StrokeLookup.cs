namespace Wacton.Desu.Strokes
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Xml;

    using Wacton.Desu.Resources;

    /// <summary>
    /// A lookup of kanji characters to strokes (source: KanjiVG)
    /// </summary>
    public class StrokeLookup : IStrokeLookup
    {
        private const string KanjiElement = "kanji";
        private const string PathElement = "path";

        private const string IdAttribute = "id";
        private const string DataAttribute = "d";

        /// <summary>
        /// Returns the lookup of kanji to strokes
        /// </summary>
        public IDictionary<string, IEnumerable<string>> GetKanjiToStrokes() => ParseKanjiToStrokes();

        /// <summary>
        /// Returns the lookup of kanji to strokes asynchronously
        /// </summary>
        public async Task<IDictionary<string, IEnumerable<string>>> GetKanjiToStrokesAsync() => await ParseKanjiToStrokesAsync();

        /// <summary>
        /// Returns the lookup of kanji to strokes
        /// </summary>
        public static IDictionary<string, IEnumerable<string>> ParseKanjiToStrokes()
        {
            return EmbeddedResources.ReadStream(Resource.KanjiStrokes, ParseDictionary);
        }

        /// <summary>
        /// Returns the lookup of kanji to strokes asynchronously
        /// </summary>
        public static async Task<IDictionary<string, IEnumerable<string>>> ParseKanjiToStrokesAsync()
        {
            return await EmbeddedResources.ReadStreamAsync(Resource.KanjiStrokes, ParseDictionaryAsync);
        }

        private static Dictionary<string, IEnumerable<string>> ParseDictionary(XmlReader reader)
        {
            var dictionaryEntries = new Dictionary<string, IEnumerable<string>>();

            reader.MoveToContent();
            while (reader.Read())
            {
                if (!IsReaderAtStartOfEntry(reader))
                {
                    continue;
                }

                var (id, paths) = ReadEntry(reader);
                dictionaryEntries.Add(id, paths);
            }

            return dictionaryEntries;
        }

        private static async Task<Dictionary<string, IEnumerable<string>>> ParseDictionaryAsync(XmlReader reader)
        {
            var dictionaryEntries = new Dictionary<string, IEnumerable<string>>();

            await reader.MoveToContentAsync();
            while (await reader.ReadAsync())
            {
                if (!IsReaderAtStartOfEntry(reader))
                {
                    continue;
                }

                var (id, paths) = await ReadEntryAsync(reader);
                dictionaryEntries.Add(id, paths);
            }

            return dictionaryEntries;
        }

        private static (string id, IEnumerable<string> paths) ReadEntry(XmlReader reader)
        {
            var id = GetId(reader);
            var paths = new List<string>();

            while (!IsReaderAtEndOfEntry(reader))
            {
                reader.Read();
                if (reader.NodeType != XmlNodeType.Element || reader.Name != PathElement)
                {
                    continue;
                }

                var path = reader.GetAttribute(DataAttribute);
                paths.Add(path);
            }

            return (id, paths);
        }

        private static async Task<(string id, IEnumerable<string> paths)> ReadEntryAsync(XmlReader reader)
        {
            var id = GetId(reader);
            var paths = new List<string>();

            while (!IsReaderAtEndOfEntry(reader))
            {
                await reader.ReadAsync();
                if (reader.NodeType != XmlNodeType.Element || reader.Name != PathElement)
                {
                    continue;
                }

                var path = reader.GetAttribute(DataAttribute);
                paths.Add(path);
            }

            return (id, paths);
        }

        private static string GetId(XmlReader reader) => reader.GetAttribute(IdAttribute).Split(new[] { "_" }, StringSplitOptions.None)[1];

        private static bool IsReaderAtStartOfEntry(XmlReader reader) => reader.NodeType == XmlNodeType.Element && reader.Name == KanjiElement;
        private static bool IsReaderAtEndOfEntry(XmlReader reader) => reader.NodeType == XmlNodeType.EndElement && reader.Name == KanjiElement;
    }
}
