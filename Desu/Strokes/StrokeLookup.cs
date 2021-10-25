namespace Wacton.Desu.Strokes
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    using Wacton.Desu.Resources;

    /// <summary>
    /// A lookup of kanji characters to strokes (source: KanjiVG)
    /// </summary>
    public class StrokeLookup : IStrokeLookup
    {
        private static readonly string KanjiElement = "kanji";
        private static readonly string PathElement = "path";

        private static readonly string IdAttribute = "id";
        private static readonly string DataAttribute = "d";

        /// <summary>
        /// Returns the lookup of kanji to strokes
        /// </summary>
        public IDictionary<string, List<string>> GetKanjiToStrokes() => ParseKanjiToStrokes();

        /// <summary>
        /// Returns the lookup of kanji to strokes
        /// </summary>
        public static IDictionary<string, List<string>> ParseKanjiToStrokes()
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
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element when reader.Name == PathElement:
                        {
                            var dataAttribute = reader.GetAttribute(DataAttribute);
                            dictionaryEntries[currentIdAttribute].Add(dataAttribute);
                            break;
                        }
                        case XmlNodeType.EndElement:
                            isEndOfEntry = reader.Name.Equals(KanjiElement);
                            break;
                    }
                }
            }

            return dictionaryEntries;
        }
    }
}
