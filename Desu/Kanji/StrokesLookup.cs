namespace Wacton.Desu.Kanji
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Xml;

    using Ionic.Zip;

    public class StrokesLookup
    {
        private const string FileName = "KanjiVG";

        private const string KanjiElement = "kanji";
        private const string PathElement = "path";
        private const string IdAttribute = "id";
        private const string DataAttribute = "d";

        private static Dictionary<string, List<string>> strokes;
        public static Dictionary<string, List<string>> Strokes
        {
            get
            {
                if (strokes != null)
                {
                    return strokes;
                }

                strokes = GetStrokes();
                return strokes;
            }
        }

        private static Stream GetEmbeddedResouceStream()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceNames = assembly.GetManifestResourceNames();
            var resourceName = resourceNames.Single(resource => resource.Contains(FileName));
            var resourceStream = assembly.GetManifestResourceStream(resourceName);
            return ZipFile.Read(resourceStream).Single().OpenReader();
        }

        private static Dictionary<string, List<string>> GetStrokes()
        {
            using (var streamReader = new StreamReader(GetEmbeddedResouceStream()))
            {
                var settings = new XmlReaderSettings { DtdProcessing = DtdProcessing.Parse };
                using (var reader = XmlReader.Create(streamReader, settings))
                {
                    return ParseDictionary(reader);
                }
            }
        }

        private static Dictionary<string, List<string>> ParseDictionary(XmlReader reader)
        {
            var dictionaryEntries = new Dictionary<string, List<string>>();

            reader.MoveToContent();
            while (reader.Read())
            {
                if (!reader.IsStartElement() || reader.Name != KanjiElement)
                {
                    continue;
                }

                var currentIdAttribute = reader.GetAttribute(IdAttribute).Split(new [] { "_" }, StringSplitOptions.None)[1];
                dictionaryEntries.Add(currentIdAttribute, new List<string>());

                var isEndOfEntry = false;
                while (!isEndOfEntry)
                {
                    reader.Read();
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == PathElement)
                    {
                        var dataAttribute = reader.GetAttribute(DataAttribute);
                        dictionaryEntries[currentIdAttribute].Add(dataAttribute);
                    }
                    else if (reader.NodeType == XmlNodeType.EndElement)
                    {
                        isEndOfEntry = reader.Name.Equals(KanjiElement);
                    }
                }
            }

            return dictionaryEntries;
        }
    }
}
