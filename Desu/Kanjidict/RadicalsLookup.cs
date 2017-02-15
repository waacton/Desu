namespace Wacton.Desu.Kanjidict
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    public static class RadicalsLookup
    {
        private static Dictionary<string, List<string>> radicalsByKanji;
        public static Dictionary<string, List<string>> RadicalsByKanji
        {
            get
            {
                if (radicalsByKanji != null)
                {
                    return radicalsByKanji;
                }

                radicalsByKanji = GetRadicalsByKanji();
                return radicalsByKanji;
            }
        }

        private static Dictionary<string, List<string>> GetRadicalsByKanji()
        {
            var kradfile1 = GetRadicalsByKanji("kradfile");
            var kradfile2 = GetRadicalsByKanji("kradfile2");
            radicalsByKanji = kradfile1.Concat(kradfile2).ToDictionary(dictionary => dictionary.Key, dictionary => dictionary.Value);
            return radicalsByKanji;
        }

        private static Dictionary<string, List<string>> GetRadicalsByKanji(string resourceNameEnding)
        {
            var dictionary = new Dictionary<string, List<string>>();

            var assembly = Assembly.GetExecutingAssembly();
            var resourceNames = assembly.GetManifestResourceNames();
            var resourceName = resourceNames.Single(resource => resource.EndsWith(resourceNameEnding));
            var resourceStream = assembly.GetManifestResourceStream(resourceName);
            using (var reader = new StreamReader(resourceStream))
            {
                var headerEnd = "###########################################################";

                var line = string.Empty;
                while (line != headerEnd)
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
    }
}
