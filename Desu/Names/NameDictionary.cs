namespace Wacton.Desu.Names
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Xml;

    using Wacton.Desu.Enums;
    using Wacton.Desu.Resources;

    /// <summary>
    /// A dictionary of Japanese proper names (source: JMnedict)
    /// </summary>
    public class NameDictionary : INameDictionary
    {
        private const string EntryTag = "entry";
        private const string CreationDatePrefix = "JMnedict created: ";
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
        /// Returns the entries of the proper names dictionary
        /// </summary>
        [Obsolete("This will be removed in version 7, use static ParseEntries instead")]
        public IEnumerable<INameEntry> GetEntries() => ParseEntries();

        /// <summary>
        /// Returns the entries of the proper names dictionary asynchronously
        /// </summary>
        [Obsolete("This will be removed in version 7, use static ParseEntriesAsync instead")]
        public async Task<IEnumerable<INameEntry>> GetEntriesAsync() => await ParseEntriesAsync();

        /// <summary>
        /// Returns the entries of the proper names dictionary
        /// </summary>
        public static IEnumerable<INameEntry> ParseEntries()
        {
            return EmbeddedResources.ReadStream(Resource.NameDictionary, ParseDictionary);
        }

        /// <summary>
        /// Returns the entries of the proper names dictionary asynchronously
        /// </summary>
        public static async Task<IEnumerable<INameEntry>> ParseEntriesAsync()
        {
            return await EmbeddedResources.ReadStreamAsync(Resource.NameDictionary, ParseDictionaryAsync);
        }

        private static IEnumerable<INameEntry> ParseDictionary(XmlReader reader)
        {
            var entries = new List<INameEntry>();

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

        private static async Task<IEnumerable<INameEntry>> ParseDictionaryAsync(XmlReader reader)
        {
            var entries = new List<INameEntry>();

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

        private static NameEntry ReadEntry(XmlReader reader)
        {
            var dictionaryEntry = new NameEntry();
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

        private static async Task<NameEntry> ReadEntryAsync(XmlReader reader)
        {
            var dictionaryEntry = new NameEntry();
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

        private static void ProcessXmlElement(XmlReader reader, NameEntry dictionaryEntry)
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

        private static async Task ProcessXmlElementAsync(XmlReader reader, NameEntry dictionaryEntry)
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
            return EmbeddedResources.ReadStream(Resource.NameDictionary, ParseCreationDate);
        }

        /// <summary>
        /// Returns the creation date of the dictionary file asynchronously
        /// </summary>
        public static async Task<DateTime> ParseCreationDateAsync()
        {
            return await EmbeddedResources.ReadStreamAsync(Resource.NameDictionary, ParseCreationDateAsync);
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
