namespace Wacton.Desu.Kanji
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Xml;

    using Wacton.Desu.Resources;

    public class StrokesLookup
    {
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

        private static Dictionary<string, List<string>> GetStrokes()
        {
            var xmlStream = EmbeddedResources.OpenKanjiStrokes();
            return EmbeddedResources.ReadXmlStream(xmlStream, ParseDictionary);
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
