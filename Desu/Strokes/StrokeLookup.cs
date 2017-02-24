namespace Wacton.Desu.Strokes
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    using Wacton.Desu.Resources;

    public class StrokeLookup : IStrokeLookup
    {
        private static readonly string KanjiElement = "kanji";
        private static readonly string PathElement = "path";

        private static readonly string IdAttribute = "id";
        private static readonly string DataAttribute = "d";

        /// <summary>
        /// Returns the lookup of kanji to strokes
        /// </summary>
        public Dictionary<string, List<string>> GetKanjiToStrokes()
        {
            return EmbeddedResources.ReadStream(Resource.KanjiStrokes, ParseDictionary);
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
