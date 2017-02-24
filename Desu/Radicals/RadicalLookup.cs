namespace Wacton.Desu.Radicals
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    using Wacton.Desu.Resources;

    public class RadicalLookup : IRadicalLookup
    {
        private static readonly string HeaderEnd = "###########################################################";

        /// <summary>
        /// Returns the lookup of kanji to radicals
        /// </summary>
        public IDictionary<string, List<string>> GetKanjiToRadicals()
        {
            var kradfile1 = EmbeddedResources.ReadStream(Resource.KanjiToRadicals1, ParseKanjiToRadicals);
            var kradfile2 = EmbeddedResources.ReadStream(Resource.KanjiToRadicals2, ParseKanjiToRadicals);
            return kradfile1.Concat(kradfile2).ToDictionary(dictionary => dictionary.Key, dictionary => dictionary.Value);
        }

        /// <summary>
        /// Returns the lookup of radical to kanjis
        /// </summary>
        public IDictionary<string, List<string>> GetRadicalToKanjis()
        {
            return EmbeddedResources.ReadStream(Resource.RadicalToKanjis, ParseRadicalToKanjis);
        }

        private static Dictionary<string, List<string>> ParseKanjiToRadicals(StreamReader streamReader)
        {
            var dictionary = new Dictionary<string, List<string>>();

            var line = string.Empty;
            while (line != HeaderEnd)
            {
                line = streamReader.ReadLine();
            }

            line = streamReader.ReadLine();

            while (line != null)
            {
                var lineElements = line.Split(new[] { ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var kanji = lineElements.First();
                var radicals = lineElements.Skip(1).ToList();
                dictionary.Add(kanji, radicals);

                line = streamReader.ReadLine();
            }

            return dictionary;
        }

        private static Dictionary<string, List<string>> ParseRadicalToKanjis(StreamReader streamReader)
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
                    foreach (var character in line)
                    {
                        dictionary[currentRadical].Add(character.ToString());
                    }                        
                }

                line = streamReader.ReadLine();
            }

            return dictionary;
        }
    }
}
