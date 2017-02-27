namespace Wacton.Desu.Kanji
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml;

    using Wacton.Desu.Enums;
    using Wacton.Desu.Resources;

    public class KanjiDictionary : IKanjiDictionary
    {
        private static readonly string CharacterTag = "character";
        private static readonly string CreationDateTag = "date_of_creation";

        private DateTime creationDate = DateTime.MinValue;

        /// <summary>
        /// The creation date of the dictionary file
        /// </summary>
        public DateTime CreationDate
        {
            get
            {
                if (this.creationDate == DateTime.MinValue)
                {
                    this.creationDate = ParseCreationDate();
                }

                return this.creationDate;
            }
        }

        /// <summary>
        /// Returns the entries of the kanji dictionary
        /// </summary>
        public IEnumerable<IKanjiEntry> GetEntries()
        {
            return EmbeddedResources.ReadStream(Resource.KanjiDictionary, ParseDictionary);
        }

        private static IEnumerable<IKanjiEntry> ParseDictionary(XmlReader reader)
        {
            var entries = new List<IKanjiEntry>();
            var characterElements = Enumeration.GetAll<CharacterElement>().ToDictionary(element => element.Code, element => element);

            reader.MoveToContent();
            while (reader.Read())
            {
                if (!reader.IsStartElement() || reader.Name != CharacterTag)
                {
                    continue;
                }

                // now within an entry, can now create data entry
                // keep reading until the end entry tag is reached
                var dictionaryEntry = new KanjiEntry();
                var isEndOfEntry = false;
                while (!isEndOfEntry)
                {
                    reader.Read();
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        var elementCode = reader.Name;
                        if (!characterElements.ContainsKey(elementCode))
                        {
                            continue;
                        }

                        var characterElement = characterElements[elementCode];
                        var characterElementData = CharacterElementData.FromXmlReader(reader);
                        characterElement.AddDataToEntry(dictionaryEntry, characterElementData);
                    }
                    else if (reader.NodeType == XmlNodeType.EndElement)
                    {
                        isEndOfEntry = reader.Name.Equals(CharacterTag);
                    }
                }

                entries.Add(dictionaryEntry);
            }

            return entries;
        }

        private static DateTime ParseCreationDate()
        {
            return EmbeddedResources.ReadStream(Resource.KanjiDictionary, ParseCreationDate);
        }

        private static DateTime ParseCreationDate(XmlReader reader)
        {
            while (reader.Read())
            {
                if (reader.NodeType != XmlNodeType.Element || reader.Name != CreationDateTag)
                {
                    continue;
                }

                var content = reader.ReadElementContentAsString();
                return DateTime.Parse(content);
            }

            return DateTime.MinValue;
        }
    }
}
