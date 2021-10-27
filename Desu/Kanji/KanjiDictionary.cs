namespace Wacton.Desu.Kanji
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Xml;

    using Wacton.Desu.Enums;
    using Wacton.Desu.Resources;

    /// <summary>
    /// A dictionary of kanji characters (source: kanjidic2)
    /// </summary>
    public class KanjiDictionary : IKanjiDictionary
    {
        private const string CharacterTag = "character";
        private const string CreationDateTag = "date_of_creation";
        private static readonly Dictionary<string, CharacterElement> CharacterElements = Enumeration.GetAll<CharacterElement>().ToDictionary(element => element.Code, element => element);

        private DateTime creationDate = DateTime.MinValue;

        /// <summary>
        /// The creation date of the dictionary file
        /// </summary>
        public DateTime CreationDate
        {
            get
            {
                if (creationDate == DateTime.MinValue)
                {
                    creationDate = ParseCreationDate();
                }

                return creationDate;
            }
        }

        /// <summary>
        /// Returns the entries of the kanji dictionary
        /// </summary>
        public IEnumerable<IKanjiEntry> GetEntries() => ParseEntries();

        /// <summary>
        /// Returns the entries of the kanji dictionary
        /// </summary>
        public async Task<IEnumerable<IKanjiEntry>> GetEntriesAsync() => await ParseEntriesAsync();

        /// <summary>
        /// Returns the entries of the kanji dictionary asynchronously
        /// </summary>
        public static IEnumerable<IKanjiEntry> ParseEntries()
        {
            return EmbeddedResources.ReadStream(Resource.KanjiDictionary, ParseDictionary);
        }

        /// <summary>
        /// Returns the entries of the kanji dictionary asynchronously
        /// </summary>
        public static async Task<IEnumerable<IKanjiEntry>> ParseEntriesAsync()
        {
            return await EmbeddedResources.ReadStreamAsync(Resource.KanjiDictionary, ParseDictionaryAsync);
        }

        private static async Task<IEnumerable<IKanjiEntry>> ParseDictionaryAsync(XmlReader reader)
        {
            var entries = new List<IKanjiEntry>();

            await reader.MoveToContentAsync();
            while (await reader.ReadAsync())
            {
                if (!IsReaderAtStartOfEntry(reader))
                {
                    continue;
                }

                var dictionaryEntry = await ReadEntryAsync(reader);
                entries.Add(dictionaryEntry);
            }

            return entries;
        }

        private static async Task<KanjiEntry> ReadEntryAsync(XmlReader reader)
        {
            var dictionaryEntry = new KanjiEntry();
            while (!IsReaderAtEndOfEntry(reader))
            {
                await reader.ReadAsync();
                if (reader.NodeType == XmlNodeType.Element)
                {
                    await ProcessXmlElementAsync(reader, dictionaryEntry);
                }
            }

            return dictionaryEntry;
        }

        private static async Task ProcessXmlElementAsync(XmlReader reader, KanjiEntry dictionaryEntry)
        {
            var elementCode = reader.Name;
            if (!CharacterElements.ContainsKey(elementCode))
            {
                return;
            }

            var characterElement = CharacterElements[elementCode];
            var characterElementData = await CharacterElementData.FromXmlReaderAsync(reader);
            characterElement.AddDataToEntry(dictionaryEntry, characterElementData);
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
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:
                        {
                            var elementCode = reader.Name;
                            if (!characterElements.ContainsKey(elementCode))
                            {
                                continue;
                            }

                            var characterElement = characterElements[elementCode];
                            var characterElementData = CharacterElementData.FromXmlReader(reader);
                            characterElement.AddDataToEntry(dictionaryEntry, characterElementData);
                            break;
                        }
                        case XmlNodeType.EndElement:
                            isEndOfEntry = reader.Name.Equals(CharacterTag);
                            break;
                    }
                }

                entries.Add(dictionaryEntry);
            }

            return entries;
        }

        private static bool IsReaderAtStartOfEntry(XmlReader reader) => reader.NodeType == XmlNodeType.Element && reader.Name == CharacterTag;
        private static bool IsReaderAtEndOfEntry(XmlReader reader) => reader.NodeType == XmlNodeType.EndElement && reader.Name == CharacterTag;

        /// <summary>
        /// Returns the creation date of the dictionary file
        /// </summary>
        public static DateTime ParseCreationDate()
        {
            return EmbeddedResources.ReadStream(Resource.KanjiDictionary, ParseCreationDate);
        }

        /// <summary>
        /// Returns the creation date of the dictionary file asynchronously
        /// </summary>
        public static async Task<DateTime> ParseCreationDateAsync()
        {
            return await EmbeddedResources.ReadStreamAsync(Resource.KanjiDictionary, ParseCreationDateAsync);
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

        private static async Task<DateTime> ParseCreationDateAsync(XmlReader reader)
        {
            while (await reader.ReadAsync())
            {
                if (reader.NodeType != XmlNodeType.Element || reader.Name != CreationDateTag)
                {
                    continue;
                }

                var content = await reader.ReadElementContentAsStringAsync();
                return DateTime.Parse(content);
            }

            return DateTime.MinValue;
        }
    }
}
