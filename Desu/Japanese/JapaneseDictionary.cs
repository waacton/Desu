namespace Wacton.Desu.Japanese
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Xml;

    using Wacton.Desu.Enums;
    using Wacton.Desu.Resources;

    /// <summary>
    /// A dictionary of Japanese words and phrases (source: JMdict)
    /// </summary>
    public class JapaneseDictionary : IJapaneseDictionary
    {
        private const string EntryTag = "entry";
        private const string CreationDatePrefix = "JMdict created: ";
        private static readonly Dictionary<string, EntryElement> EntryElements = Enumeration.GetAll<EntryElement>().ToDictionary(element => element.Code, element => element);
 
        private DateTime creationDate = DateTime.MinValue;

        /// <summary>
        /// The creation date of the dictionary file
        /// </summary>
        [Obsolete("This will be removed in version 7, use static ParseCreationDate or ParseCreationDateAsync instead")]
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
        /// Returns the entries of the Japanese dictionary
        /// </summary>
        [Obsolete("This will be removed in version 7, use static ParseEntries instead")]
        public IEnumerable<IJapaneseEntry> GetEntries() => ParseEntries();

        /// <summary>
        /// Returns the entries of the Japanese dictionary asynchronously
        /// </summary>
        [Obsolete("This will be removed in version 7, use static ParseEntriesAsync instead")]
        public async Task<IEnumerable<IJapaneseEntry>> GetEntriesAsync() => await ParseEntriesAsync();

        /// <summary>
        /// Returns the entries of the Japanese dictionary
        /// </summary>
        public static IEnumerable<IJapaneseEntry> ParseEntries()
        {
            return EmbeddedResources.ReadStream(Resource.JapaneseDictionary, ParseDictionary);
        }

        /// <summary>
        /// Returns the entries of the Japanese dictionary asynchronously
        /// </summary>
        public static async Task<IEnumerable<IJapaneseEntry>> ParseEntriesAsync()
        {
            return await EmbeddedResources.ReadStreamAsync(Resource.JapaneseDictionary, ParseDictionaryAsync);
        }

        private static IEnumerable<IJapaneseEntry> ParseDictionary(XmlReader reader)
        {
            var entries = new List<IJapaneseEntry>();

            reader.MoveToContent();
            while (reader.Read())
            {
                if (!IsReaderAtStartOfEntry(reader))
                {
                    continue;
                }

                var dictionaryEntry = ReadEntry(reader);
                entries.Add(dictionaryEntry);
            }

            return entries;
        }

        private static async Task<IEnumerable<IJapaneseEntry>> ParseDictionaryAsync(XmlReader reader)
        {
            var entries = new List<IJapaneseEntry>();

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

        private static JapaneseEntry ReadEntry(XmlReader reader)
        {
            var dictionaryEntry = new JapaneseEntry();
            while (!IsReaderAtEndOfEntry(reader))
            {
                reader.Read();
                if (reader.NodeType == XmlNodeType.Element)
                {
                    ProcessXmlElement(reader, dictionaryEntry);
                }
            }

            return dictionaryEntry;
        }

        private static async Task<JapaneseEntry> ReadEntryAsync(XmlReader reader)
        {
            var dictionaryEntry = new JapaneseEntry();
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

        private static void ProcessXmlElement(XmlReader reader, JapaneseEntry dictionaryEntry)
        {
            var elementCode = reader.Name;
            if (!EntryElements.ContainsKey(elementCode))
            {
                return;
            }

            var entryElement = EntryElements[elementCode];
            if (!entryElement.ExpectsContent)
            {
                entryElement.AddDataToEntry(dictionaryEntry, null);
                return;
            }

            var entryElementData = EntryElementData.FromXmlReader(reader);
            entryElement.AddDataToEntry(dictionaryEntry, entryElementData);
        }

        private static async Task ProcessXmlElementAsync(XmlReader reader, JapaneseEntry dictionaryEntry)
        {
            var elementCode = reader.Name;
            if (!EntryElements.ContainsKey(elementCode))
            {
                return;
            }

            var entryElement = EntryElements[elementCode];
            if (!entryElement.ExpectsContent)
            {
                entryElement.AddDataToEntry(dictionaryEntry, null);
                return;
            }

            var entryElementData = await EntryElementData.FromXmlReaderAsync(reader);
            entryElement.AddDataToEntry(dictionaryEntry, entryElementData);
        }

        private static bool IsReaderAtStartOfEntry(XmlReader reader) => reader.NodeType == XmlNodeType.Element && reader.Name == EntryTag;
        private static bool IsReaderAtEndOfEntry(XmlReader reader) => reader.NodeType == XmlNodeType.EndElement && reader.Name == EntryTag;

        /// <summary>
        /// Returns the creation date of the dictionary file
        /// </summary>
        public static DateTime ParseCreationDate()
        {
            return EmbeddedResources.ReadStream(Resource.JapaneseDictionary, ParseCreationDate);
        }

        /// <summary>
        /// Returns the creation date of the dictionary file asynchronously
        /// </summary>
        public static async Task<DateTime> ParseCreationDateAsync()
        {
            return await EmbeddedResources.ReadStreamAsync(Resource.JapaneseDictionary, ParseCreationDateAsync);
        }

        private static DateTime ParseCreationDate(XmlReader reader)
        {
            while (reader.Read())
            {
                var (success, dateTime) = TryGetDateTime(reader);
                if (success)
                {
                    return dateTime;
                }
            }

            return DateTime.MinValue;
        }

        private static async Task<DateTime> ParseCreationDateAsync(XmlReader reader)
        {
            while (await reader.ReadAsync())
            {
                var (success, dateTime) = TryGetDateTime(reader);
                if (success)
                {
                    return dateTime;
                }
            }

            return DateTime.MinValue;
        }

        private static (bool success, DateTime dateTime) TryGetDateTime(XmlReader reader)
        {
            if (reader.NodeType != XmlNodeType.Comment)
            {
                return (false, DateTime.MinValue);
            }

            if (!reader.Value.Contains(CreationDatePrefix))
            {
                return (false, DateTime.MinValue);
            }

            var commentSplit = reader.Value.Split(new[] { CreationDatePrefix }, StringSplitOptions.RemoveEmptyEntries);
            return (true, DateTime.Parse(commentSplit[1]));
        }
    }
}
