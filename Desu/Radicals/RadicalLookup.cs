namespace Wacton.Desu.Radicals
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;

    using Wacton.Desu.Resources;

    /// <summary>
    /// A lookup between kanji characters and radicals (sources: kradfile, kradfile2, radkfilex)
    /// </summary>
    public class RadicalLookup : IRadicalLookup
    {
        private const string HeaderEnd = "###########################################################";

        /// <summary>
        /// Returns the lookup of kanji to radicals
        /// </summary>
        public IDictionary<string, IEnumerable<string>> GetKanjiToRadicals() => ParseKanjiToRadicals();

        /// <summary>
        /// Returns the lookup of kanji to radicals asynchronously
        /// </summary>
        public async Task<IDictionary<string, IEnumerable<string>>> GetKanjiToRadicalsAsync() => await ParseKanjiToRadicalsAsync();

        /// <summary>
        /// Returns the lookup of kanji to radicals
        /// </summary>
        public static IDictionary<string, IEnumerable<string>> ParseKanjiToRadicals()
        {
            var kradfile1 = EmbeddedResources.ReadStream(Resource.KanjiToRadicals1, ParseKanjiToRadicals);
            var kradfile2 = EmbeddedResources.ReadStream(Resource.KanjiToRadicals2, ParseKanjiToRadicals);
            return kradfile1.Concat(kradfile2).ToDictionary(dictionary => dictionary.Key, dictionary => dictionary.Value);
        }

        /// <summary>
        /// Returns the lookup of kanji to radicals asynchronously
        /// </summary>
        public static async Task<IDictionary<string, IEnumerable<string>>> ParseKanjiToRadicalsAsync()
        {
            var kradfile1 = await EmbeddedResources.ReadStreamAsync(Resource.KanjiToRadicals1, ParseKanjiToRadicalsAsync);
            var kradfile2 = await EmbeddedResources.ReadStreamAsync(Resource.KanjiToRadicals2, ParseKanjiToRadicalsAsync);
            return kradfile1.Concat(kradfile2).ToDictionary(dictionary => dictionary.Key, dictionary => dictionary.Value);
        }

        private static Dictionary<string, IEnumerable<string>> ParseKanjiToRadicals(StreamReader streamReader)
        {
            var dictionary = new Dictionary<string, IEnumerable<string>>();

            var line = string.Empty;
            while (line != HeaderEnd)
            {
                line = streamReader.ReadLine();
            }

            line = streamReader.ReadLine();

            while (line != null)
            {
                var (kanji, radicals) = GetKanjiToRadicals(line);
                dictionary.Add(kanji, radicals);

                line = streamReader.ReadLine();
            }

            return dictionary;
        }

        private static async Task<Dictionary<string, IEnumerable<string>>> ParseKanjiToRadicalsAsync(StreamReader streamReader)
        {
            var dictionary = new Dictionary<string, IEnumerable<string>>();

            var line = string.Empty;
            while (line != HeaderEnd)
            {
                line = await streamReader.ReadLineAsync();
            }

            line = await streamReader.ReadLineAsync();

            while (line != null)
            {
                var (kanji, radicals) = GetKanjiToRadicals(line);
                dictionary.Add(kanji, radicals);

                line = await streamReader.ReadLineAsync();
            }

            return dictionary;
        }

        private static (string kanji, List<string> radicals) GetKanjiToRadicals(string line)
        {
            var lineElements = line.Split(new[] { ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var kanji = lineElements.First();
            var radicals = lineElements.Skip(1).ToList();
            return (kanji, radicals);
        }

        /// <summary>
        /// Returns the lookup of radical to kanjis
        /// </summary>
        public IDictionary<string, IEnumerable<string>> GetRadicalToKanjis() => ParseRadicalToKanjis();

        /// <summary>
        /// Returns the lookup of radical to kanjis asynchronously
        /// </summary>
        public async Task<IDictionary<string, IEnumerable<string>>> GetRadicalToKanjisAsync() => await ParseRadicalToKanjisAsync();

        /// <summary>
        /// Returns the lookup of radical to kanjis
        /// </summary>
        public static IDictionary<string, IEnumerable<string>> ParseRadicalToKanjis()
        {
            return EmbeddedResources.ReadStream(Resource.RadicalToKanjis, ParseRadicalToKanjis);
        }

        /// <summary>
        /// Returns the lookup of radical to kanjis asynchronously
        /// </summary>
        public static async Task<IDictionary<string, IEnumerable<string>>> ParseRadicalToKanjisAsync()
        {
            return await EmbeddedResources.ReadStreamAsync(Resource.RadicalToKanjis, ParseRadicalToKanjisAsync);
        }

        private static Dictionary<string, IEnumerable<string>> ParseRadicalToKanjis(StreamReader streamReader)
        {
            var dictionary = new Dictionary<string, List<string>>();

            var line = string.Empty;
            while (line != HeaderEnd)
            {
                line = streamReader.ReadLine();
            }

            line = streamReader.ReadLine();

            var currentRadical = string.Empty;
            while (line != null)
            {
                if (line.StartsWith("$"))
                {
                    currentRadical = line.Split(' ')[1];
                    dictionary.Add(currentRadical, new List<string>());
                }
                else
                {
                    var kanjis = line.Select(character => character.ToString());
                    dictionary[currentRadical].AddRange(kanjis);
                }

                line = streamReader.ReadLine();
            }

            return ToEnumerableValues(dictionary);
        }

        private static async Task<Dictionary<string, IEnumerable<string>>> ParseRadicalToKanjisAsync(StreamReader streamReader)
        {
            var dictionary = new Dictionary<string, List<string>>();

            var line = string.Empty;
            while (line != HeaderEnd)
            {
                line = await streamReader.ReadLineAsync();
            }

            line = await streamReader.ReadLineAsync();

            var currentRadical = string.Empty;
            while (line != null)
            {
                if (line.StartsWith("$"))
                {
                    currentRadical = line.Split(' ')[1];
                    dictionary.Add(currentRadical, new List<string>());
                }
                else
                {
                    var kanjis = line.Select(character => character.ToString());
                    dictionary[currentRadical].AddRange(kanjis);
                }

                line = await streamReader.ReadLineAsync();
            }

            return ToEnumerableValues(dictionary);
        }

        private static Dictionary<string, IEnumerable<string>> ToEnumerableValues(Dictionary<string, List<string>> dictionary)
        {
            return dictionary.ToDictionary(item => item.Key, item => item.Value.Select(x => x));
        }
    }
}
