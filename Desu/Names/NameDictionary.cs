namespace Wacton.Desu.Names
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml;

    using Wacton.Desu.Enums;
    using Wacton.Desu.Resources;

    public class NameDictionary : INameDictionary
    {
        private static readonly string EntryTag = "entry";
        private static readonly string CreationDatePrefix = "JMnedict created: ";

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
        /// Returns the entries of the proper names dictionary
        /// </summary>
        public IEnumerable<INameEntry> GetEntries() => ParseEntries();

        /// <summary>
        /// Returns the entries of the proper names dictionary
        /// </summary>
        public static IEnumerable<INameEntry> ParseEntries()
        {
            return EmbeddedResources.ReadStream(Resource.NameDictionary, ParseDictionary);
        }

        private static IEnumerable<INameEntry> ParseDictionary(XmlReader reader)
        {
            var entries = new List<INameEntry>();
            var entryElements = Enumeration.GetAll<EntryElement>().ToDictionary(element => element.Code, element => element);

            reader.MoveToContent();
            while (reader.Read())
            {
                if (!reader.IsStartElement() || reader.Name != EntryTag)
                {
                    continue;
                }

                // now within an entry, can now create data entry
                // keep reading until the end entry tag is reached
                var dictionaryEntry = new NameEntry();
                var isEndOfEntry = false;
                while (!isEndOfEntry)
                {
                    reader.Read();
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        var elementCode = reader.Name;
                        if (!entryElements.ContainsKey(elementCode))
                        {
                            continue;
                        }

                        var entryElement = entryElements[elementCode];
                        if (!entryElement.ExpectsContent)
                        {
                            entryElement.AddDataToEntry(dictionaryEntry, null);
                            continue;
                        }

                        var entryElementData = EntryElementData.FromXmlReader(reader);
                        entryElement.AddDataToEntry(dictionaryEntry, entryElementData);
                    }
                    else if (reader.NodeType == XmlNodeType.EndElement)
                    {
                        isEndOfEntry = reader.Name.Equals(EntryTag);
                    }
                }

                entries.Add(dictionaryEntry);
            }

            return entries;
        }

        /// <summary>
        /// Returns the creation date of the dictionary file
        /// </summary>
        public static DateTime ParseCreationDate()
        {
            return EmbeddedResources.ReadStream(Resource.NameDictionary, ParseCreationDate);
        }

        private static DateTime ParseCreationDate(XmlReader reader)
        {
            while (reader.Read())
            {
                if (reader.NodeType != XmlNodeType.Comment)
                {
                    continue;
                }

                if (!reader.Value.Contains(CreationDatePrefix))
                {
                    continue;
                }

                var commentSplit = reader.Value.Split(new[] { CreationDatePrefix }, StringSplitOptions.RemoveEmptyEntries);
                return DateTime.Parse(commentSplit[1]);
            }

            return DateTime.MinValue;
        }
    }
}
