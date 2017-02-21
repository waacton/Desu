namespace Wacton.Desu.Kanji
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    using Wacton.Desu.Resources;

    public static class RadicalsLookup
    {
        private static Dictionary<string, List<string>> kanjiToRadicals;
        public static Dictionary<string, List<string>> KanjiToRadicals
        {
            get
            {
                if (kanjiToRadicals != null)
                {
                    return kanjiToRadicals;
                }

                kanjiToRadicals = GetKanjiToRadicals();
                return kanjiToRadicals;
            }
        }

        private static Dictionary<string, List<string>> radicalToKanjis;
        public static Dictionary<string, List<string>> RadicalToKanjis
        {
            get
            {
                if (radicalToKanjis != null)
                {
                    return radicalToKanjis;
                }

                radicalToKanjis = GetKanjiByRadicals();
                return radicalToKanjis;
            }
        }

        private static readonly string HeaderEnd = "###########################################################";

        private static Dictionary<string, List<string>> GetKanjiToRadicals()
        {
            var kradfile1 = GetKanjiToRadicals(EmbeddedResources.OpenKanjiToRadicals1());
            var kradfile2 = GetKanjiToRadicals(EmbeddedResources.OpenKanjiToRadicals2());
            return kradfile1.Concat(kradfile2).ToDictionary(dictionary => dictionary.Key, dictionary => dictionary.Value);
        }

        private static Dictionary<string, List<string>> GetKanjiToRadicals(Stream radicalsToKanjiStream)
        {
            var dictionary = new Dictionary<string, List<string>>();

            using (var reader = new StreamReader(radicalsToKanjiStream))
            {
                var line = string.Empty;
                while (line != HeaderEnd)
                {
                    line = reader.ReadLine();
                }

                line = reader.ReadLine();

                while (line != null)
                {
                    var lineElements = line.Split(new[] { ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    var kanji = lineElements.First();
                    var radicals = lineElements.Skip(1).ToList();
                    dictionary.Add(kanji, radicals);

                    line = reader.ReadLine();
                }
            }

            return dictionary;
        }

        private static Dictionary<string, List<string>> GetKanjiByRadicals()
        {
            var dictionary = new Dictionary<string, List<string>>();

            using (var reader = new StreamReader(EmbeddedResources.OpenRadicalToKanjis()))
            {
                var line = string.Empty;
                while (line != HeaderEnd)
                {
                    line = reader.ReadLine();
                }

                line = reader.ReadLine();

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

                    line = reader.ReadLine();
                }
            }

            return dictionary;
        }
    }
}
